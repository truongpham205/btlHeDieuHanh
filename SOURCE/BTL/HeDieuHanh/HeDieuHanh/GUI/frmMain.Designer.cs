namespace HeDieuHanh
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTaskManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMusic = new System.Windows.Forms.ToolStripButton();
            this.tlpDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVolumn = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.tlpBatery = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.progressBarBartery = new System.Windows.Forms.ProgressBar();
            this.tlpInternet = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.internetStatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tlpDisplay.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpVolumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.tlpBatery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tlpInternet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpDisplay, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaskManager,
            this.toolStripSeparator1,
            this.btnMusic});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(139, 507);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskManager.Image")));
            this.btnTaskManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaskManager.Margin = new System.Windows.Forms.Padding(0, 30, 0, 2);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(137, 24);
            this.btnTaskManager.Text = "TaskManager";
            this.btnTaskManager.Click += new System.EventHandler(this.btnTaskManager_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // btnMusic
            // 
            this.btnMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnMusic.Image")));
            this.btnMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusic.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(137, 24);
            this.btnMusic.Text = "Music";
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // tlpDisplay
            // 
            this.tlpDisplay.ColumnCount = 1;
            this.tlpDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisplay.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tlpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisplay.Location = new System.Drawing.Point(142, 3);
            this.tlpDisplay.Name = "tlpDisplay";
            this.tlpDisplay.RowCount = 2;
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDisplay.Size = new System.Drawing.Size(787, 501);
            this.tlpDisplay.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tlpVolumn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tlpBatery, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tlpInternet, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 453);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(781, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tlpVolumn
            // 
            this.tlpVolumn.ColumnCount = 2;
            this.tlpVolumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVolumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpVolumn.Controls.Add(this.pictureBox2, 0, 0);
            this.tlpVolumn.Controls.Add(this.trackBarVolume, 1, 0);
            this.tlpVolumn.Location = new System.Drawing.Point(471, 3);
            this.tlpVolumn.Name = "tlpVolumn";
            this.tlpVolumn.RowCount = 1;
            this.tlpVolumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVolumn.Size = new System.Drawing.Size(150, 39);
            this.tlpVolumn.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 33);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarVolume.Location = new System.Drawing.Point(33, 3);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(114, 33);
            this.trackBarVolume.TabIndex = 1;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // tlpBatery
            // 
            this.tlpBatery.ColumnCount = 2;
            this.tlpBatery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBatery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpBatery.Controls.Add(this.pictureBox3, 0, 0);
            this.tlpBatery.Controls.Add(this.progressBarBartery, 1, 0);
            this.tlpBatery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBatery.Location = new System.Drawing.Point(627, 3);
            this.tlpBatery.Name = "tlpBatery";
            this.tlpBatery.RowCount = 1;
            this.tlpBatery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBatery.Size = new System.Drawing.Size(151, 39);
            this.tlpBatery.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 33);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // progressBarBartery
            // 
            this.progressBarBartery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarBartery.Location = new System.Drawing.Point(33, 3);
            this.progressBarBartery.Name = "progressBarBartery";
            this.progressBarBartery.Size = new System.Drawing.Size(115, 33);
            this.progressBarBartery.TabIndex = 1;
            // 
            // tlpInternet
            // 
            this.tlpInternet.ColumnCount = 2;
            this.tlpInternet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInternet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpInternet.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpInternet.Controls.Add(this.internetStatusLabel, 1, 0);
            this.tlpInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInternet.Location = new System.Drawing.Point(315, 3);
            this.tlpInternet.Name = "tlpInternet";
            this.tlpInternet.RowCount = 1;
            this.tlpInternet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInternet.Size = new System.Drawing.Size(150, 39);
            this.tlpInternet.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 33);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // internetStatusLabel
            // 
            this.internetStatusLabel.AutoSize = true;
            this.internetStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.internetStatusLabel.Location = new System.Drawing.Point(33, 0);
            this.internetStatusLabel.Name = "internetStatusLabel";
            this.internetStatusLabel.Size = new System.Drawing.Size(114, 39);
            this.internetStatusLabel.TabIndex = 1;
            this.internetStatusLabel.Text = "Not Connect";
            this.internetStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Hệ điều hành";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tlpDisplay.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpVolumn.ResumeLayout(false);
            this.tlpVolumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.tlpBatery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tlpInternet.ResumeLayout(false);
            this.tlpInternet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTaskManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMusic;
        private System.Windows.Forms.TableLayoutPanel tlpDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpVolumn;
        private System.Windows.Forms.TableLayoutPanel tlpBatery;
        private System.Windows.Forms.TableLayoutPanel tlpInternet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label internetStatusLabel;
        private System.Windows.Forms.ProgressBar progressBarBartery;
    }
}

