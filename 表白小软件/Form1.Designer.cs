namespace 表白小软件
{
    partial class fm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm));
            this.btOK = new System.Windows.Forms.Button();
            this.btNO = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btOK, "btOK");
            this.btOK.Name = "btOK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btNO
            // 
            resources.ApplyResources(this.btNO, "btNO");
            this.btNO.Name = "btNO";
            this.btNO.UseVisualStyleBackColor = true;
            this.btNO.Click += new System.EventHandler(this.btNO_Click);
            this.btNO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btNO_MouseMove);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::表白小软件.Properties.Resources.TIM图片20180805202421;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lb
            // 
            resources.ApplyResources(this.lb, "lb");
            this.lb.Name = "lb";
            this.lb.Click += new System.EventHandler(this.lb_Click);
            // 
            // fm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btNO);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fm_FormClosed);
            this.Load += new System.EventHandler(this.送给亲爱的你_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btNO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb;
    }
}

