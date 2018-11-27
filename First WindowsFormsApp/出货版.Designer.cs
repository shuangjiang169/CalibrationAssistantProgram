namespace First_WindowsFormsApp
{
    partial class 出货版
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(出货版));
            this.label1 = new System.Windows.Forms.Label();
            this.KtextBox = new System.Windows.Forms.TextBox();
            this.btnxy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numtextBox = new System.Windows.Forms.TextBox();
            this.btnnumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tBopenfile = new System.Windows.Forms.TextBox();
            this.tBgpxs = new System.Windows.Forms.TextBox();
            this.userCurve1 = new HslCommunication.Controls.UserCurve();
            this.btnsave = new System.Windows.Forms.Button();
            this.butpic = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "系数K";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KtextBox
            // 
            this.KtextBox.Location = new System.Drawing.Point(87, 415);
            this.KtextBox.Name = "KtextBox";
            this.KtextBox.Size = new System.Drawing.Size(106, 21);
            this.KtextBox.TabIndex = 1;
            this.KtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnxy
            // 
            this.btnxy.Location = new System.Drawing.Point(502, 413);
            this.btnxy.Name = "btnxy";
            this.btnxy.Size = new System.Drawing.Size(75, 23);
            this.btnxy.TabIndex = 2;
            this.btnxy.Text = "取出KB系数";
            this.btnxy.UseVisualStyleBackColor = true;
            this.btnxy.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "系数B";
            // 
            // BtextBox
            // 
            this.BtextBox.Location = new System.Drawing.Point(304, 415);
            this.BtextBox.Name = "BtextBox";
            this.BtextBox.Size = new System.Drawing.Size(100, 21);
            this.BtextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "仪器序列号";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numtextBox
            // 
            this.numtextBox.Location = new System.Drawing.Point(116, 9);
            this.numtextBox.Name = "numtextBox";
            this.numtextBox.Size = new System.Drawing.Size(100, 21);
            this.numtextBox.TabIndex = 6;
            this.numtextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnnumber
            // 
            this.btnnumber.Location = new System.Drawing.Point(42, 469);
            this.btnnumber.Name = "btnnumber";
            this.btnnumber.Size = new System.Drawing.Size(174, 54);
            this.btnnumber.TabIndex = 7;
            this.btnnumber.Text = "调试版修改序列号";
            this.btnnumber.UseVisualStyleBackColor = true;
            this.btnnumber.Click += new System.EventHandler(this.btnnumber_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "出货版修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "绘制gpxs曲线图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "打开gpxs文件";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tBopenfile
            // 
            this.tBopenfile.Location = new System.Drawing.Point(116, 41);
            this.tBopenfile.Name = "tBopenfile";
            this.tBopenfile.Size = new System.Drawing.Size(387, 21);
            this.tBopenfile.TabIndex = 13;
            // 
            // tBgpxs
            // 
            this.tBgpxs.Location = new System.Drawing.Point(35, 72);
            this.tBgpxs.Multiline = true;
            this.tBgpxs.Name = "tBgpxs";
            this.tBgpxs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBgpxs.Size = new System.Drawing.Size(263, 322);
            this.tBgpxs.TabIndex = 14;
            // 
            // userCurve1
            // 
            this.userCurve1.AllowDrop = true;
            this.userCurve1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve1.IsAbscissaStrech = true;
            this.userCurve1.Location = new System.Drawing.Point(315, 91);
            this.userCurve1.Name = "userCurve1";
            this.userCurve1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userCurve1.Size = new System.Drawing.Size(666, 303);
            this.userCurve1.StrechDataCountMax = 402;
            this.userCurve1.TabIndex = 15;
            this.userCurve1.ValueMaxLeft = 3F;
            this.userCurve1.ValueMaxRight = 3F;
            this.userCurve1.ValueSegment = 10;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(374, 484);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(138, 24);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "保存当前页面值";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // butpic
            // 
            this.butpic.Location = new System.Drawing.Point(374, 514);
            this.butpic.Name = "butpic";
            this.butpic.Size = new System.Drawing.Size(138, 24);
            this.butpic.TabIndex = 17;
            this.butpic.Text = "截图保存";
            this.butpic.UseVisualStyleBackColor = true;
            this.butpic.Click += new System.EventHandler(this.butpic_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(733, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "触发版修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 出货版
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butpic);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.userCurve1);
            this.Controls.Add(this.tBgpxs);
            this.Controls.Add(this.tBopenfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnnumber);
            this.Controls.Add(this.numtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnxy);
            this.Controls.Add(this.KtextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "出货版";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KtextBox;
        private System.Windows.Forms.Button btnxy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numtextBox;
        private System.Windows.Forms.Button btnnumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBopenfile;
        private System.Windows.Forms.TextBox tBgpxs;
        private HslCommunication.Controls.UserCurve userCurve1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button butpic;
        private System.Windows.Forms.Button button3;
    }
}

