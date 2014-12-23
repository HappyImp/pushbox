namespace 推箱子
{
    partial class MapConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapConfig));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DesBut = new System.Windows.Forms.ToolStripButton();
            this.WorkerBut = new System.Windows.Forms.ToolStripButton();
            this.BoxBut = new System.Windows.Forms.ToolStripButton();
            this.PasBut = new System.Windows.Forms.ToolStripButton();
            this.WallBut = new System.Windows.Forms.ToolStripButton();
            this.ClearBut = new System.Windows.Forms.ToolStripButton();
            this.SaveBut = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DesBut,
            this.WorkerBut,
            this.BoxBut,
            this.PasBut,
            this.WallBut,
            this.ClearBut,
            this.SaveBut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(515, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // DesBut
            // 
            this.DesBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DesBut.Image = ((System.Drawing.Image)(resources.GetObject("DesBut.Image")));
            this.DesBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DesBut.Name = "DesBut";
            this.DesBut.Size = new System.Drawing.Size(34, 34);
            this.DesBut.Text = "toolStripButton1";
            this.DesBut.Click += new System.EventHandler(this.DesBut_Click);
            // 
            // WorkerBut
            // 
            this.WorkerBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WorkerBut.Image = ((System.Drawing.Image)(resources.GetObject("WorkerBut.Image")));
            this.WorkerBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WorkerBut.Name = "WorkerBut";
            this.WorkerBut.Size = new System.Drawing.Size(34, 34);
            this.WorkerBut.Text = "toolStripButton2";
            this.WorkerBut.Click += new System.EventHandler(this.WorkerBut_Click);
            // 
            // BoxBut
            // 
            this.BoxBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoxBut.Image = ((System.Drawing.Image)(resources.GetObject("BoxBut.Image")));
            this.BoxBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoxBut.Name = "BoxBut";
            this.BoxBut.Size = new System.Drawing.Size(34, 34);
            this.BoxBut.Text = "toolStripButton3";
            this.BoxBut.Click += new System.EventHandler(this.BoxBut_Click);
            // 
            // PasBut
            // 
            this.PasBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasBut.Image = ((System.Drawing.Image)(resources.GetObject("PasBut.Image")));
            this.PasBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasBut.Name = "PasBut";
            this.PasBut.Size = new System.Drawing.Size(34, 34);
            this.PasBut.Text = "toolStripButton4";
            this.PasBut.Click += new System.EventHandler(this.PasBut_Click);
            // 
            // WallBut
            // 
            this.WallBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WallBut.Image = ((System.Drawing.Image)(resources.GetObject("WallBut.Image")));
            this.WallBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WallBut.Name = "WallBut";
            this.WallBut.Size = new System.Drawing.Size(34, 34);
            this.WallBut.Text = "toolStripButton5";
            this.WallBut.Click += new System.EventHandler(this.WallBut_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearBut.Image = ((System.Drawing.Image)(resources.GetObject("ClearBut.Image")));
            this.ClearBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(34, 34);
            this.ClearBut.Text = "清除";
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveBut.Image = ((System.Drawing.Image)(resources.GetObject("SaveBut.Image")));
            this.SaveBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(34, 34);
            this.SaveBut.Text = "保存";
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 477);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // MapConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MapConfig";
            this.Text = "MapConfig";
            this.Load += new System.EventHandler(this.MapConfig_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DesBut;
        private System.Windows.Forms.ToolStripButton WorkerBut;
        private System.Windows.Forms.ToolStripButton BoxBut;
        private System.Windows.Forms.ToolStripButton PasBut;
        private System.Windows.Forms.ToolStripButton WallBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton ClearBut;
        private System.Windows.Forms.ToolStripButton SaveBut;
    }
}