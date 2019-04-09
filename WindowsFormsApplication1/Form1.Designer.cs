namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textImg = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBigImg = new System.Windows.Forms.TextBox();
            this.textDetailImg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labBigImageCount = new System.Windows.Forms.Label();
            this.labDetailImageCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labErrorImageCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxImageList = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtImageTypes = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textImg
            // 
            this.textImg.ContextMenuStrip = this.contextMenuStrip1;
            this.textImg.Location = new System.Drawing.Point(277, 153);
            this.textImg.Multiline = true;
            this.textImg.Name = "textImg";
            this.textImg.Size = new System.Drawing.Size(461, 150);
            this.textImg.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空ToolStripMenuItem.Text = "清空地址";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "图片地址：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "下 载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "大图下载址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "详情图下载地址：";
            // 
            // textBigImg
            // 
            this.textBigImg.Location = new System.Drawing.Point(277, 22);
            this.textBigImg.Name = "textBigImg";
            this.textBigImg.ReadOnly = true;
            this.textBigImg.Size = new System.Drawing.Size(461, 21);
            this.textBigImg.TabIndex = 5;
            this.textBigImg.Text = "C:\\Users\\dianshang\\Desktop\\临时\\";
            // 
            // textDetailImg
            // 
            this.textDetailImg.Location = new System.Drawing.Point(277, 68);
            this.textDetailImg.Name = "textDetailImg";
            this.textDetailImg.ReadOnly = true;
            this.textDetailImg.Size = new System.Drawing.Size(461, 21);
            this.textDetailImg.TabIndex = 6;
            this.textDetailImg.Text = "C:\\Users\\dianshang\\Desktop\\临时\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "(以反斜杠结尾)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(763, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "打开文件位置";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "大图数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "详情图数量：";
            // 
            // labBigImageCount
            // 
            this.labBigImageCount.AutoSize = true;
            this.labBigImageCount.Location = new System.Drawing.Point(134, 32);
            this.labBigImageCount.Name = "labBigImageCount";
            this.labBigImageCount.Size = new System.Drawing.Size(11, 12);
            this.labBigImageCount.TabIndex = 10;
            this.labBigImageCount.Text = "0";
            // 
            // labDetailImageCount
            // 
            this.labDetailImageCount.AutoSize = true;
            this.labDetailImageCount.Location = new System.Drawing.Point(134, 63);
            this.labDetailImageCount.Name = "labDetailImageCount";
            this.labDetailImageCount.Size = new System.Drawing.Size(11, 12);
            this.labDetailImageCount.TabIndex = 10;
            this.labDetailImageCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "下载失败数量：";
            // 
            // labErrorImageCount
            // 
            this.labErrorImageCount.AutoSize = true;
            this.labErrorImageCount.Location = new System.Drawing.Point(134, 137);
            this.labErrorImageCount.Name = "labErrorImageCount";
            this.labErrorImageCount.Size = new System.Drawing.Size(11, 12);
            this.labErrorImageCount.TabIndex = 10;
            this.labErrorImageCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "下载失败图片地址：";
            // 
            // txtBoxImageList
            // 
            this.txtBoxImageList.Location = new System.Drawing.Point(136, 161);
            this.txtBoxImageList.Multiline = true;
            this.txtBoxImageList.Name = "txtBoxImageList";
            this.txtBoxImageList.ReadOnly = true;
            this.txtBoxImageList.Size = new System.Drawing.Size(461, 77);
            this.txtBoxImageList.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labBigImageCount);
            this.groupBox1.Controls.Add(this.txtBoxImageList);
            this.groupBox1.Controls.Add(this.labErrorImageCount);
            this.groupBox1.Controls.Add(this.labDetailImageCount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(148, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 288);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "下载统计分析";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "需要下载的图片类型(使用“|”分隔)：";
            // 
            // txtImageTypes
            // 
            this.txtImageTypes.Location = new System.Drawing.Point(765, 179);
            this.txtImageTypes.Name = "txtImageTypes";
            this.txtImageTypes.Size = new System.Drawing.Size(244, 21);
            this.txtImageTypes.TabIndex = 14;
            this.txtImageTypes.Text = "jpg|png|jpeg|gif|bmp|svg|psd";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(857, 25);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 12);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "设置文件路径";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 228);
            this.label8.MaximumSize = new System.Drawing.Size(260, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "提示：鼠标放在图片地址框里，点击鼠标右键，可以清空图片地址";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 676);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImageTypes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDetailImg);
            this.Controls.Add(this.textBigImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textImg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBigImg;
        private System.Windows.Forms.TextBox textDetailImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labBigImageCount;
        private System.Windows.Forms.Label labDetailImageCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labErrorImageCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxImageList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImageTypes;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.Label label8;
    }
}

