namespace Mastersign.Bible.GlasOcean
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.propertyRender = new System.Windows.Forms.PropertyGrid();
            this.picture = new de.mastersign.controls.ZoomPictureBox();
            this.propertyLife = new System.Windows.Forms.PropertyGrid();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNextPopulationSeed = new System.Windows.Forms.Button();
            this.btnNextDecisionSeed = new System.Windows.Forms.Button();
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.flowLayout.SuspendLayout();
            this.flowLayoutMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.propertyRender, 0, 2);
            this.tableLayout.Controls.Add(this.picture, 1, 1);
            this.tableLayout.Controls.Add(this.propertyLife, 0, 1);
            this.tableLayout.Controls.Add(this.flowLayout, 1, 0);
            this.tableLayout.Controls.Add(this.flowLayoutMenu, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(814, 566);
            this.tableLayout.TabIndex = 0;
            // 
            // propertyRender
            // 
            this.propertyRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyRender.HelpVisible = false;
            this.propertyRender.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyRender.Location = new System.Drawing.Point(3, 303);
            this.propertyRender.Name = "propertyRender";
            this.propertyRender.Size = new System.Drawing.Size(294, 260);
            this.propertyRender.TabIndex = 2;
            this.propertyRender.ToolbarVisible = false;
            // 
            // picture
            // 
            this.picture.AllowLineSelection = false;
            this.picture.AllwaysShowOverlay = false;
            this.picture.ButtonBack1 = System.Drawing.SystemColors.Control;
            this.picture.ButtonBack2 = System.Drawing.SystemColors.ControlDark;
            this.picture.ButtonBackDisabled1 = System.Drawing.SystemColors.ControlLight;
            this.picture.ButtonBackDisabled2 = System.Drawing.SystemColors.Control;
            this.picture.ButtonBackHover1 = System.Drawing.SystemColors.ControlLightLight;
            this.picture.ButtonBackHover2 = System.Drawing.SystemColors.ControlDark;
            this.picture.ButtonBackSwitched1 = System.Drawing.SystemColors.ControlDark;
            this.picture.ButtonBackSwitched2 = System.Drawing.SystemColors.ControlLight;
            this.picture.ButtonBorder = System.Drawing.SystemColors.ControlDark;
            this.picture.ButtonBorderDisabled = System.Drawing.SystemColors.ControlDark;
            this.picture.ButtonBorderHover = System.Drawing.SystemColors.ControlDarkDark;
            this.picture.ButtonBorderSwitched = System.Drawing.SystemColors.ControlDarkDark;
            this.picture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Image = null;
            this.picture.ImageOffset = ((System.Drawing.PointF)(resources.GetObject("picture.ImageOffset")));
            this.picture.InfoBackgroundColor = System.Drawing.SystemColors.Window;
            this.picture.InfoForegroundColor = System.Drawing.SystemColors.WindowText;
            this.picture.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.picture.IsBoundToMaster = false;
            this.picture.Location = new System.Drawing.Point(300, 35);
            this.picture.Margin = new System.Windows.Forms.Padding(0);
            this.picture.Master = null;
            this.picture.Name = "picture";
            this.picture.OrientationBackgroundColor = System.Drawing.SystemColors.Window;
            this.picture.OrientationForegroundColor = System.Drawing.SystemColors.WindowText;
            this.picture.Overlay = de.mastersign.controls.ZoomPictureBox.OverlayMode.Both;
            this.picture.Rotation = 0F;
            this.tableLayout.SetRowSpan(this.picture, 2);
            this.picture.ShowMeasureTools = false;
            this.picture.ShowRotationTools = false;
            this.picture.ShowSelectionTools = false;
            this.picture.ShowZoomLevelTools = true;
            this.picture.Size = new System.Drawing.Size(514, 531);
            this.picture.SuppressInterpolation = false;
            this.picture.TabIndex = 0;
            this.picture.WaitAnimationInterval = 50;
            this.picture.WaitingAnimation = false;
            this.picture.WaitingAnimationBlend = false;
            this.picture.Zoom = 0F;
            // 
            // propertyLife
            // 
            this.propertyLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyLife.HelpVisible = false;
            this.propertyLife.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyLife.Location = new System.Drawing.Point(3, 38);
            this.propertyLife.Name = "propertyLife";
            this.propertyLife.Size = new System.Drawing.Size(294, 259);
            this.propertyLife.TabIndex = 1;
            this.propertyLife.ToolbarVisible = false;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoSize = true;
            this.flowLayout.Controls.Add(this.btnStart);
            this.flowLayout.Controls.Add(this.btnNextPopulationSeed);
            this.flowLayout.Controls.Add(this.btnNextDecisionSeed);
            this.flowLayout.Controls.Add(this.btnSavePicture);
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout.Location = new System.Drawing.Point(303, 3);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(508, 29);
            this.flowLayout.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(57, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Render";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNextPopulationSeed
            // 
            this.btnNextPopulationSeed.Location = new System.Drawing.Point(66, 3);
            this.btnNextPopulationSeed.Name = "btnNextPopulationSeed";
            this.btnNextPopulationSeed.Size = new System.Drawing.Size(93, 23);
            this.btnNextPopulationSeed.TabIndex = 0;
            this.btnNextPopulationSeed.Text = "New Structure";
            this.btnNextPopulationSeed.UseVisualStyleBackColor = true;
            this.btnNextPopulationSeed.Click += new System.EventHandler(this.btnNextPopulationSeed_Click);
            // 
            // btnNextDecisionSeed
            // 
            this.btnNextDecisionSeed.Location = new System.Drawing.Point(165, 3);
            this.btnNextDecisionSeed.Name = "btnNextDecisionSeed";
            this.btnNextDecisionSeed.Size = new System.Drawing.Size(93, 23);
            this.btnNextDecisionSeed.TabIndex = 0;
            this.btnNextDecisionSeed.Text = "New Variation";
            this.btnNextDecisionSeed.UseVisualStyleBackColor = true;
            this.btnNextDecisionSeed.Click += new System.EventHandler(this.btnNextDecisionSeed_Click);
            // 
            // flowLayoutMenu
            // 
            this.flowLayoutMenu.AutoSize = true;
            this.flowLayoutMenu.Controls.Add(this.btnLoad);
            this.flowLayoutMenu.Controls.Add(this.btnSave);
            this.flowLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMenu.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutMenu.Name = "flowLayoutMenu";
            this.flowLayoutMenu.Size = new System.Drawing.Size(294, 29);
            this.flowLayoutMenu.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSavePicture
            // 
            this.btnSavePicture.Location = new System.Drawing.Point(264, 3);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(92, 23);
            this.btnSavePicture.TabIndex = 1;
            this.btnSavePicture.Text = "Save Picture";
            this.btnSavePicture.UseVisualStyleBackColor = true;
            this.btnSavePicture.Click += new System.EventHandler(this.btnSavePicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 566);
            this.Controls.Add(this.tableLayout);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.flowLayout.ResumeLayout(false);
            this.flowLayoutMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private de.mastersign.controls.ZoomPictureBox picture;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PropertyGrid propertyRender;
        private System.Windows.Forms.PropertyGrid propertyLife;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Button btnNextPopulationSeed;
        private System.Windows.Forms.Button btnNextDecisionSeed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSavePicture;
    }
}