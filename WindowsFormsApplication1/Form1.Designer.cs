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
            this.btnDownload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.labSuccessImageCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labErrorImageCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxErrorImageList = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtImageTypes = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbImageNameTemplate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIsRemoveParam = new System.Windows.Forms.CheckBox();
            this.tbDefaultExtendName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textImg
            // 
            this.textImg.AllowDrop = true;
            this.textImg.ContextMenuStrip = this.contextMenuStrip1;
            this.textImg.Location = new System.Drawing.Point(277, 115);
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
            this.label1.Location = new System.Drawing.Point(147, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "图片地址：分隔符：|";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(148, 165);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(113, 49);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "下 载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片保存地址：";
            // 
            // txtSaveImage
            // 
            this.txtSaveImage.Location = new System.Drawing.Point(277, 22);
            this.txtSaveImage.Name = "txtSaveImage";
            this.txtSaveImage.ReadOnly = true;
            this.txtSaveImage.Size = new System.Drawing.Size(461, 21);
            this.txtSaveImage.TabIndex = 5;
            this.txtSaveImage.Text = "C:\\Users\\lixianghong\\Desktop\\临时";
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
            this.label5.Text = "成功数量：";
            // 
            // labSuccessImageCount
            // 
            this.labSuccessImageCount.AutoSize = true;
            this.labSuccessImageCount.Location = new System.Drawing.Point(134, 32);
            this.labSuccessImageCount.Name = "labSuccessImageCount";
            this.labSuccessImageCount.Size = new System.Drawing.Size(11, 12);
            this.labSuccessImageCount.TabIndex = 10;
            this.labSuccessImageCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "下载失败数量：";
            // 
            // labErrorImageCount
            // 
            this.labErrorImageCount.AutoSize = true;
            this.labErrorImageCount.Location = new System.Drawing.Point(134, 84);
            this.labErrorImageCount.Name = "labErrorImageCount";
            this.labErrorImageCount.Size = new System.Drawing.Size(11, 12);
            this.labErrorImageCount.TabIndex = 10;
            this.labErrorImageCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "下载失败图片地址：";
            // 
            // txtBoxErrorImageList
            // 
            this.txtBoxErrorImageList.Location = new System.Drawing.Point(136, 108);
            this.txtBoxErrorImageList.Multiline = true;
            this.txtBoxErrorImageList.Name = "txtBoxErrorImageList";
            this.txtBoxErrorImageList.ReadOnly = true;
            this.txtBoxErrorImageList.Size = new System.Drawing.Size(461, 77);
            this.txtBoxErrorImageList.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labSuccessImageCount);
            this.groupBox1.Controls.Add(this.txtBoxErrorImageList);
            this.groupBox1.Controls.Add(this.labErrorImageCount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(148, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 213);
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
            this.label7.Location = new System.Drawing.Point(763, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "需要下载的图片类型(使用“|”分隔)：";
            // 
            // txtImageTypes
            // 
            this.txtImageTypes.Location = new System.Drawing.Point(765, 152);
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
            this.label8.Location = new System.Drawing.Point(763, 241);
            this.label8.MaximumSize = new System.Drawing.Size(260, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "提示：鼠标放在图片地址框里，点击鼠标右键，可以清空图片地址";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "图片命名规则：";
            // 
            // tbImageNameTemplate
            // 
            this.tbImageNameTemplate.Location = new System.Drawing.Point(275, 68);
            this.tbImageNameTemplate.Name = "tbImageNameTemplate";
            this.tbImageNameTemplate.Size = new System.Drawing.Size(461, 21);
            this.tbImageNameTemplate.TabIndex = 6;
            this.tbImageNameTemplate.Text = "SPU-{Query_filename}-XH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "支持：{序号},{Query_参数名}";
            // 
            // cbIsRemoveParam
            // 
            this.cbIsRemoveParam.AutoSize = true;
            this.cbIsRemoveParam.Location = new System.Drawing.Point(765, 96);
            this.cbIsRemoveParam.Name = "cbIsRemoveParam";
            this.cbIsRemoveParam.Size = new System.Drawing.Size(96, 16);
            this.cbIsRemoveParam.TabIndex = 16;
            this.cbIsRemoveParam.Text = "移除链接参数";
            this.cbIsRemoveParam.UseVisualStyleBackColor = true;
            // 
            // tbDefaultExtendName
            // 
            this.tbDefaultExtendName.Location = new System.Drawing.Point(882, 193);
            this.tbDefaultExtendName.Name = "tbDefaultExtendName";
            this.tbDefaultExtendName.Size = new System.Drawing.Size(127, 21);
            this.tbDefaultExtendName.TabIndex = 17;
            this.tbDefaultExtendName.Text = "jpg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "无扩展名默认类型：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 575);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDefaultExtendName);
            this.Controls.Add(this.cbIsRemoveParam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImageTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbImageNameTemplate);
            this.Controls.Add(this.txtSaveImage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDownload);
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
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSuccessImageCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labErrorImageCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxErrorImageList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImageTypes;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbImageNameTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbIsRemoveParam;
        private System.Windows.Forms.TextBox tbDefaultExtendName;
        private System.Windows.Forms.Label label6;
    }
}

