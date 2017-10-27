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
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripLabel tslScale;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.propertyRender = new System.Windows.Forms.PropertyGrid();
            this.picture = new de.mastersign.controls.ZoomPictureBox();
            this.propertyLife = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbNewPopulation = new System.Windows.Forms.ToolStripButton();
            this.tsbNewVariation = new System.Windows.Forms.ToolStripButton();
            this.tscbScale = new System.Windows.Forms.ToolStripComboBox();
            this.tsbRender = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSavePicture = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tslScale = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayout.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslScale
            // 
            tslScale.Name = "tslScale";
            tslScale.Size = new System.Drawing.Size(37, 22);
            tslScale.Text = "Scale:";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.propertyRender, 0, 1);
            this.tableLayout.Controls.Add(this.picture, 1, 0);
            this.tableLayout.Controls.Add(this.propertyLife, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 25);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(814, 541);
            this.tableLayout.TabIndex = 0;
            // 
            // propertyRender
            // 
            this.propertyRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyRender.HelpVisible = false;
            this.propertyRender.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyRender.Location = new System.Drawing.Point(3, 273);
            this.propertyRender.Name = "propertyRender";
            this.propertyRender.Size = new System.Drawing.Size(294, 265);
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
            this.picture.Location = new System.Drawing.Point(300, 0);
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
            this.picture.Size = new System.Drawing.Size(514, 541);
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
            this.propertyLife.Location = new System.Drawing.Point(3, 3);
            this.propertyLife.Name = "propertyLife";
            this.propertyLife.Size = new System.Drawing.Size(294, 264);
            this.propertyLife.TabIndex = 1;
            this.propertyLife.ToolbarVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            toolStripSeparator1,
            this.tsbNewPopulation,
            this.tsbNewVariation,
            toolStripSeparator2,
            tslScale,
            this.tscbScale,
            this.tsbRender,
            this.tsbCancel,
            this.toolStripSeparator3,
            this.tsbSavePicture});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(40, 22);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.ToolTipText = "Open configuration from *.gmeer file.";
            this.tsbOpen.Click += new System.EventHandler(this.OpenConfigurationHandler);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(35, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.SaveConfigurationHandler);
            // 
            // tsbNewPopulation
            // 
            this.tsbNewPopulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewPopulation.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPopulation.Image")));
            this.tsbNewPopulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPopulation.Name = "tsbNewPopulation";
            this.tsbNewPopulation.Size = new System.Drawing.Size(96, 22);
            this.tsbNewPopulation.Text = "New Population";
            this.tsbNewPopulation.Click += new System.EventHandler(this.NewPopulationHandler);
            // 
            // tsbNewVariation
            // 
            this.tsbNewVariation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewVariation.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewVariation.Image")));
            this.tsbNewVariation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewVariation.Name = "tsbNewVariation";
            this.tsbNewVariation.Size = new System.Drawing.Size(84, 22);
            this.tsbNewVariation.Text = "New Variation";
            this.tsbNewVariation.Click += new System.EventHandler(this.NewVariationHandler);
            // 
            // tscbScale
            // 
            this.tscbScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbScale.MaxDropDownItems = 10;
            this.tscbScale.Name = "tscbScale";
            this.tscbScale.Size = new System.Drawing.Size(75, 25);
            // 
            // tsbRender
            // 
            this.tsbRender.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRender.Image = ((System.Drawing.Image)(resources.GetObject("tsbRender.Image")));
            this.tsbRender.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRender.Name = "tsbRender";
            this.tsbRender.Size = new System.Drawing.Size(51, 22);
            this.tsbRender.Text = "Render!";
            this.tsbRender.Click += new System.EventHandler(this.RenderHandler);
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(47, 22);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.Click += new System.EventHandler(this.CancelHandler);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSavePicture
            // 
            this.tsbSavePicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSavePicture.Image = ((System.Drawing.Image)(resources.GetObject("tsbSavePicture.Image")));
            this.tsbSavePicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSavePicture.Name = "tsbSavePicture";
            this.tsbSavePicture.Size = new System.Drawing.Size(75, 22);
            this.tsbSavePicture.Text = "Save Picture";
            this.tsbSavePicture.Click += new System.EventHandler(this.SavePictureHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 566);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayout.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private de.mastersign.controls.ZoomPictureBox picture;
        private System.Windows.Forms.PropertyGrid propertyRender;
        private System.Windows.Forms.PropertyGrid propertyLife;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbNewPopulation;
        private System.Windows.Forms.ToolStripButton tsbNewVariation;
        private System.Windows.Forms.ToolStripComboBox tscbScale;
        private System.Windows.Forms.ToolStripButton tsbRender;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSavePicture;
    }
}