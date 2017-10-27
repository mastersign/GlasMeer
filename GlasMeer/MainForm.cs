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

        public MainForm()
        {
            InitializeComponent();
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
        }

        public bool IsRendering
        {
            get => isRendering;
            set
            {
                isRendering = value;
                flowLayout.Enabled = !isRendering;
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
            };
        }

        private async void Render()
        {
            if (IsRendering) return;
            IsRendering = true;
            picture.Image = await RenderAsync();
            IsRendering = false;
        }

        private Task<Bitmap> RenderAsync()
        {
            var task = new Task<Bitmap>(() =>
            {
                var individualGenerator = new IndividualGenerator(config.LifeParameter);
                var renderEngine = new RenderEngine(config.RenderOptions);
                var individuals = individualGenerator.Generate();
                return renderEngine.Render(individuals, SnapshotHandler, new TimeSpan(0, 0, 0, 0, 200));
            });
            task.Start();
            return task;
        }

        private void SnapshotHandler(Bitmap bmp)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action<Bitmap>)SnapshotHandler, bmp);
                return;
            }
            picture.Image = bmp;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void btnNextPopulationSeed_Click(object sender, EventArgs e)
        {
            config.LifeParameter.PopulationRandomSeed = rand.Next();
            UpdateUI();
            Render();
        }

        private void btnNextDecisionSeed_Click(object sender, EventArgs e)
        {
            config.LifeParameter.DecisionRandomSeed = rand.Next();
            UpdateUI();
            Render();
        }

        private void btnLoad_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnSavePicture_Click(object sender, EventArgs e)
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
