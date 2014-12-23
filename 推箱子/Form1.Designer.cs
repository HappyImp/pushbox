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
            this.NewBut = new System.Windows.Forms.ToolStripButton();
            this.NextBut = new System.Windows.Forms.ToolStripButton();
            this.UndoBut = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBut,
            this.NextBut,
            this.toolStripButton1,
            this.UndoBut,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(536, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewBut
            // 
            this.NewBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewBut.Image = ((System.Drawing.Image)(resources.GetObject("NewBut.Image")));
            this.NewBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBut.Name = "NewBut";
            this.NewBut.Size = new System.Drawing.Size(23, 22);
            this.NewBut.Text = "新建地图";
            this.NewBut.Click += new System.EventHandler(this.NewBut_Click);
            // 
            // NextBut
            // 
            this.NextBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextBut.Image = ((System.Drawing.Image)(resources.GetObject("NextBut.Image")));
            this.NextBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(23, 22);
            this.NextBut.Text = "下一关";
            this.NextBut.Click += new System.EventHandler(this.NextBut_Click);
            // 
            // UndoBut
            // 
            this.UndoBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoBut.Image = ((System.Drawing.Image)(resources.GetObject("UndoBut.Image")));
            this.UndoBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoBut.Name = "UndoBut";
            this.UndoBut.Size = new System.Drawing.Size(23, 22);
            this.UndoBut.Text = "撤销";
            this.UndoBut.Click += new System.EventHandler(this.UndoBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 369);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // CountLable
            // 
            this.CountLable.AutoSize = true;
            this.CountLable.Location = new System.Drawing.Point(189, 41);
            this.CountLable.Name = "CountLable";
            this.CountLable.Size = new System.Drawing.Size(41, 12);
            this.CountLable.TabIndex = 3;
            this.CountLable.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "用时：0秒";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton1.Text = "上一关";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton2.Text = "选关";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
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

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton NextBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton UndoBut;
        private System.Windows.Forms.Label CountLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

