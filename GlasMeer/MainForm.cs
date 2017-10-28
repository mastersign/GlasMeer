using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.Bible.GlasOcean
{
    public partial class MainForm : Form
    {
        string loadedConfigFile;
        GlasMeerConfiguration config;
        readonly Random rand = new Random();
        bool isRendering;
        CancellationToken cancellationToken;

        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
            InitializeConfiguration();
            UpdateUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var targetScreen = (from s in Screen.AllScreens where !s.Primary select s).LastOrDefault() ?? Screen.PrimaryScreen;
            var sb = targetScreen.Bounds;
            SetBounds(sb.X + 100, sb.Y + 100, sb.Width - 200, sb.Height - 200);
            WindowState = FormWindowState.Maximized;
            Render();
        }

        private void InitializeUI()
        {
            tscbScale.Items.Add(0.5f);
            tscbScale.Items.Add(0.75f);
            tscbScale.Items.Add(1.0f);
            tscbScale.Items.Add(1.5f);
            tscbScale.Items.Add(2.0f);
            tscbScale.Items.Add(3.0f);
            tscbScale.Items.Add(4.0f);
            tscbScale.Items.Add(5.0f);
            tscbScale.Items.Add(10.0f);
            tscbScale.SelectedItem = 1.0f;
        }

        private void InitializeConfiguration()
        {
            config = new GlasMeerConfiguration
            {
                LifeParameter = DefaultLifeParameter(),
                RenderOptions = DefaultRenderOptions(),
            };
        }

        private void UpdateUI()
        {
            propertyLife.SelectedObject = config.LifeParameter;
            propertyRender.SelectedObject = config.RenderOptions;
            tsbOpen.Enabled = !IsRendering;
            tsbNewPopulation.Enabled = !IsRendering;
            tsbNewVariation.Enabled = !IsRendering;
            tscbScale.Enabled = !IsRendering;
            tsbRender.Enabled = !IsRendering;
            tsbCancel.Enabled = IsRendering;
            tsbSavePicture.Enabled = !IsRendering;
        }

        public bool IsRendering
        {
            get => isRendering;
            set
            {
                isRendering = value;
                UpdateUI();
            }
        }

        private RenderStats renderStats;
        private RenderStats LastRenderStats
        {
            get => renderStats;
            set
            {
                renderStats = value;
                tsslIndividuals.Text = renderStats.IndividualCount.ToString();
                tsslDecisions.Text = renderStats.DecisionCount.ToString();
                tsslAlternativeDecisions.Text = renderStats.AlternativeDecisionCount.ToString();
                tsslRenderTime.Text = renderStats.Time.ToString();
            }
        }

        private LifeParameter DefaultLifeParameter()
        {
            return new LifeParameter
            {
                PopulationRandomSeed = 0,
                DecisionRandomSeed = 0,
                MaxTime = 600f,
                MinLifeSpan = 10f,
                MaxLifeSpan = 110f,
                DeathProbability = 0f,
                MinDecisionDelta = 1f,
                MaxDecisionDelta = 5f,
                MinDecisionDuration = 3f,
                MaxDecisionDuration = 10f,
                MinDecisionValue = -0.4f,
                MaxDecisionValue = +0.3f,
                MinAlternatives = 0,
                MaxAlternatives = 1,
                AlternativeDecay = 0.5f,
                AlternativeFactor = 0.2f,
                AlternativeDepthThreshold = 4,
                MinShiftFactor = 0.2f,
                MaxShiftFactor = 2f,
                MinPregnancyAge = 20f,
                MaxPregnancyAge = 60f,
                PregnancyProbability = 0.2f,
            };
        }

        private RenderOptions DefaultRenderOptions()
        {
            return new RenderOptions
            {
                CanvasSize = new Size(1300, 860),
                Padding = new Padding(20),
                HorizonRatio = 0.5f,
                LineWidth = 3f,
                PositionStretch = 50f,
                TimeStretch = 2f,
                BackgroundColor = Color.Black,
                BirthPointColor = Color.FromArgb(160, 255, 255, 255),
                BirthPointSize = 6f,
                GoodColor = Color.FromArgb(220, 192, 240, 255),
                NeutralColor = Color.FromArgb(200, 192, 192, 192),
                BadColor = Color.FromArgb(160, 255, 0, 0),
                ShowAlternatives = true,
                ShowBirthPoint = true,
                PivotIndex = 0,
                PivotOnly = false,
                HighlightPivot = false,
                HighlightColor = Color.Red,
                HighlightDimOpacity = 0.5f,
            };
        }

        private async void Render()
        {
            if (IsRendering) return;
            IsRendering = true;
            var scaleFactor = (float)tscbScale.SelectedItem;
            ShowRenderResult(await RenderAsync(scaleFactor, SnapshotHandler));
            IsRendering = false;
        }

        private Task<RenderResult> RenderAsync(float scaleFactor, Action<RenderResult> snapshotHandler)
        {
            cancellationToken = new CancellationToken();
            var task = new Task<RenderResult>(() =>
            {
                var individualGenerator = new IndividualGenerator(config.LifeParameter);
                var renderEngine = new RenderEngine(config.RenderOptions.Scale(scaleFactor));
                var individuals = individualGenerator.Generate();
                return renderEngine.Render(individuals, 
                    snapshotHandler, new TimeSpan(0, 0, 0, 0, 500), 
                    cancellationToken);
            });
            task.Start();
            return task;
        }

        private void SnapshotHandler(RenderResult result)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action<RenderResult>)SnapshotHandler, result);
                return;
            }
            ShowRenderResult(result);
        }

        private void ShowRenderResult(RenderResult result)
        {
            LastRenderStats = result.Stats;
            var bmp = result.Picture;
            var oldSize = picture.Image?.Size ?? new Size();
            var newSize = bmp?.Size ?? new Size();
            picture.Image = bmp;
            if (oldSize != newSize) picture.ViewFit();
        }

        private void OpenConfigurationHandler(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Load GlasMeer Configuration...",
                AddExtension = true,
                DefaultExt = ".gmeer",
                Filter = "GlasMeer Configuration (*.gmeer)|*.gmeer",
                CheckFileExists = true,
                FileName = loadedConfigFile,
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                loadedConfigFile = dialog.FileName;
                var newConfig = GlasMeerConfiguration.Load(dialog.FileName);
                if (newConfig != null)
                {
                    config = newConfig;
                    UpdateUI();
                    Render();
                }
            }
        }
        private void SaveConfigurationHandler(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Title = "Save GlasMeer Configuration...",
                AddExtension = true,
                DefaultExt = ".gmeer",
                Filter = "GlasMeer Configuration (*.gmeer)|*.gmeer",
                OverwritePrompt = true,
                FileName = loadedConfigFile,
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                loadedConfigFile = dialog.FileName;
                config.Safe(dialog.FileName);
            }
        }
        private void NewPopulationHandler(object sender, EventArgs e)
        {
            config.LifeParameter.PopulationRandomSeed = rand.Next();
            UpdateUI();
            Render();
        }

        private void NewVariationHandler(object sender, EventArgs e)
        {
            config.LifeParameter.DecisionRandomSeed = rand.Next();
            UpdateUI();
            Render();
        }
        private void NewPivotHandler(object sender, EventArgs e)
        {
            config.RenderOptions.PivotIndex = LastRenderStats != null
                ? (long)Math.Floor(rand.NextDouble() * LastRenderStats.IndividualCount)
                : 0L;
            UpdateUI();
            Render();
        }

        private void RenderHandler(object sender, EventArgs e)
        {
            Render();
        }

        private void CancelHandler(object sender, EventArgs e)
        {
            cancellationToken?.Cancel();
        }

        private void SavePictureHandler(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Title = "Save GlasMeer Picture...",
                AddExtension = true,
                DefaultExt = ".png",
                Filter = "Portable Network Graphic (*.png)|*.png",
                OverwritePrompt = true,
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image.Save(dialog.FileName); 
            }
        }
    }
}
