namespace 推箱子
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.CountLable = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewBut = new System.Windows.Forms.ToolStripButton();
            this.LastBut = new System.Windows.Forms.ToolStripButton();
            this.NextBut = new System.Windows.Forms.ToolStripButton();
            this.UndoBut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.refresh = new System.Windows.Forms.ToolStripButton();
            this.good = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBut,
            this.LastBut,
            this.NextBut,
            this.UndoBut,
            this.toolStripButton2,
            this.refresh,
            this.good});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "关卡";
            // 
            // CountLable
            // 
            this.CountLable.AutoSize = true;
            this.CountLable.Location = new System.Drawing.Point(189, 41);
            this.CountLable.Name = "CountLable";
            this.CountLable.Size = new System.Drawing.Size(29, 12);
            this.CountLable.TabIndex = 3;
            this.CountLable.Text = "步数";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(331, 41);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 12);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "用时：0秒";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NewBut
            // 
            this.NewBut.AutoSize = false;
            this.NewBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewBut.Image = ((System.Drawing.Image)(resources.GetObject("NewBut.Image")));
            this.NewBut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBut.Name = "NewBut";
            this.NewBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewBut.Size = new System.Drawing.Size(25, 25);
            this.NewBut.Text = "新建地图";
            this.NewBut.Click += new System.EventHandler(this.NewBut_Click);
            // 
            // LastBut
            // 
            this.LastBut.AutoSize = false;
            this.LastBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastBut.Image = ((System.Drawing.Image)(resources.GetObject("LastBut.Image")));
            this.LastBut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LastBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastBut.Name = "LastBut";
            this.LastBut.Size = new System.Drawing.Size(25, 25);
            this.LastBut.Text = "上一关";
            this.LastBut.Click += new System.EventHandler(this.LastBut_Click);
            // 
            // NextBut
            // 
            this.NextBut.AutoSize = false;
            this.NextBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextBut.Image = ((System.Drawing.Image)(resources.GetObject("NextBut.Image")));
            this.NextBut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NextBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(25, 25);
            this.NextBut.Text = "下一关";
            this.NextBut.Click += new System.EventHandler(this.NextBut_Click);
            // 
            // UndoBut
            // 
            this.UndoBut.AutoSize = false;
            this.UndoBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoBut.Image = ((System.Drawing.Image)(resources.GetObject("UndoBut.Image")));
            this.UndoBut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UndoBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoBut.Name = "UndoBut";
            this.UndoBut.Size = new System.Drawing.Size(25, 25);
            this.UndoBut.Text = "撤销";
            this.UndoBut.Click += new System.EventHandler(this.UndoBut_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton2.Text = "选关";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // refresh
            // 
            this.refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(24, 25);
            this.refresh.Text = "刷新";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // good
            // 
            this.good.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.good.Image = ((System.Drawing.Image)(resources.GetObject("good.Image")));
            this.good.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.good.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(24, 25);
            this.good.Text = "good";
            this.good.Click += new System.EventHandler(this.good_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 506);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.CountLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "WorkMan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton NewBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton NextBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton UndoBut;
        private System.Windows.Forms.Label CountLable;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton LastBut;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton refresh;
        private System.Windows.Forms.ToolStripButton good;
    }
}

