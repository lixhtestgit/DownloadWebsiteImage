using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        #region 属性
        public static WebClient WebClient = new WebClient();
        //一次最大读取的字节数100KB
        public const int MAX_READ_BYTE_LENGTH = 102400;

        public static string Loading = "下载中...{0}%";
        private string _imageTypes { get; set; }
        public string ImageTypes
        {
            get
            {
                if (string.IsNullOrEmpty(this._imageTypes))
                {
                    this._imageTypes = this.txtImageTypes.Text;
                }
                return this._imageTypes;
            }
        }
        public DownloadImage DownLoadImage { get; set; }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 开始下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //https://img10.360buyimg.com//img10.360buyimg.com/n5/jfs/t16648/127/676229886/381380/5cd0ff57/5a9f9803N5f6fb75e.jpg,https://img10.360buyimg.com//img10.360buyimg.com/n5/jfs/t11536/149/923156565/176376/5b1f83d3/59fb36cbN8bf5f999.jpg,https://img10.360buyimg.com//img10.360buyimg.com/n5/jfs/t4849/287/2366502398/51002/e4c78c7e/58fda42cN8257ef81.jpg,https://img10.360buyimg.com//img10.360buyimg.com/n5/jfs/t5224/163/352052465/49811/5e4b226d/58fda430N425183cb.jpg,https://img10.360buyimg.com//img10.360buyimg.com/n5/jfs/t5224/174/350178704/61947/90178883/58fda433Nf158a71b.jpg,https://img10.360buyimg.com//img10.360buyimg.com/n5/jfs/t4417/170/3446005181/67590/d683b206/58fda435Naba3ac26.jpg,https://img10.360buyimg.com//img20.360buyimg.com/vc/jfs/t1/2745/1/4354/231848/5b9b93c3Ed674c3cc/07c8b03154c71c47.jpg,https://img10.360buyimg.com//img20.360buyimg.com/vc/jfs/t10786/236/1312431261/94610/f6ab7662/59df2ce1N95f655ea.jpg,https://img10.360buyimg.com//img20.360buyimg.com/vc/jfs/t9541/280/1317436849/102051/668300b5/59df2cf9Nb08435bb.jpg,https://img10.360buyimg.com//img20.360buyimg.com/vc/jfs/t9616/319/1333136873/65831/1c2e16f3/59df2ceeNb1ddc7eb.jpg,https://img10.360buyimg.com//img20.360buyimg.com/vc/jfs/t9511/286/1314865248/57885/8c850701/59df2d06Ne4738e2b.jpg,https://img10.360buyimg.com//img20.360buyimg.com/vc/jfs/t10351/357/1323797830/81592/5106a6c4/59df2d0fN4a518ee4.jpg,https://img10.360buyimg.com//img20.360buyimg.com/vc/jfs/t10792/298/1311076768/100638/2702f731/59df2d11Nb95bb14e.jpg

            #region 检查页面数据
            if (string.IsNullOrEmpty(this.textImg.Text) || string.IsNullOrEmpty(this.ImageTypes))
            {
                MessageBox.Show("请填写图片地址！");
                return;
            }
            this.DownLoadImage = new DownloadImage()
            {
                DownLoadImageUrl = this.textImg.Text,
                FileBigImageFilePath = this.textBigImg.Text,
                FileDetailImageFilePath = this.textDetailImg.Text,
                RegexImageUrl = new Regex(string.Format(@"^http(s*)://.+\.({0})\?(big|detail)$", this.ImageTypes))
            };
            this.CheckDirectory(this.DownLoadImage.FileBigImageFilePath);
            this.CheckDirectory(this.DownLoadImage.FileDetailImageFilePath);

            #endregion

            //1-开始下载图片
            this.button1.Enabled = false;
            this.DownLoadImage.BeginDownLoadImage(this.DownLoadImage, this.updateLoadingStr);

            //2-下载结束
            this.button1.Text = "下 载";
            this.button1.Enabled = true;
            MessageBox.Show("下载完成！");
        }
        /// <summary>
        /// 打开文件所在位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileBigImageFilePath = textBigImg.Text;
            this.CheckDirectory(fileBigImageFilePath);

            System.Diagnostics.Process.Start(fileBigImageFilePath);
        }
        /// <summary>
        /// 设置文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBigImg.Text = this.textDetailImg.Text = dialog.SelectedPath + "\\";
            }
        }

        /// <summary>
        /// 实时更新下载统计面板
        /// </summary>
        /// <param name="downLoadImage"></param>
        /// <param name="formatStr"></param>
        private void updateLoadingStr()
        {
            double shang = (this.DownLoadImage.BigImageDownLoadCount + this.DownLoadImage.DetailImageDownLoadCount) * 1.0 / this.DownLoadImage.ImageTotalCount;
            this.button1.Text = string.Format(Form1.Loading, (int)(shang * 100));

            labBigImageCount.Text = this.DownLoadImage.BigImageDownLoadCount.ToString();
            labDetailImageCount.Text = this.DownLoadImage.DetailImageDownLoadCount.ToString();
            labErrorImageCount.Text = this.DownLoadImage.ImageErrorCount.ToString();
            txtBoxImageList.Text = string.Join(",", this.DownLoadImage.ImageErrorUrlList);

            this.button1.Update();
            this.labBigImageCount.Update();
            this.labDetailImageCount.Update();
            this.labErrorImageCount.Update();
            this.txtBoxImageList.Update();
        }

        /// <summary>
        /// 检查文件夹是否存在，不存在则自动创建
        /// </summary>
        /// <param name="path"></param>
        private void CheckDirectory(string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
        }

        /// <summary>
        /// 清空下载地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textImg.Text = "";
        }
    }

    /// <summary>
    /// 图片下载类
    /// </summary>
    public class DownloadImage
    {
        /// <summary>
        /// 一次读取的最大字节数
        /// </summary>
        public int OneMaxReadByteLength = 102400;

        /// <summary>
        /// 检查图片地址正则
        /// </summary>
        public Regex RegexImageUrl { get; set; }
        /// <summary>
        /// 新的下载地址
        /// </summary>
        public string DownLoadImageUrl { get; set; }
        /// <summary>
        /// 大图文件下载地址
        /// </summary>
        public string FileBigImageFilePath { get; set; }
        /// <summary>
        /// 详情图文件下载地址
        /// </summary>
        public string FileDetailImageFilePath { get; set; }


        /// <summary>
        /// 图片总量
        /// </summary>
        public int ImageTotalCount { get; set; }
        /// <summary>
        /// 图片移除总量
        /// </summary>
        public int ImageRemoveTotalCount { get; set; }
        /// <summary>
        /// 大图下载成功数
        /// </summary>
        public int BigImageDownLoadCount { get; set; }
        /// <summary>
        /// 大图下载成功地址列表
        /// </summary>
        public List<string> BigImageDownLoadUrlList = new List<string>(0);
        /// <summary>
        /// 详情图下载成功数
        /// </summary>
        public int DetailImageDownLoadCount { get; set; }
        /// <summary>
        /// 详情图下载成功地址列表
        /// </summary>
        public List<string> DetailImageDownLoadUrlList = new List<string>(0);
        /// <summary>
        /// 图片下载失败数量
        /// </summary>
        public int ImageErrorCount { get; set; }
        /// <summary>
        /// 图片下载失败地址列表
        /// </summary>
        public List<string> ImageErrorUrlList = new List<string>(0);

        /// <summary>
        /// 检查图片地址有效性（-2无效详情图地址，-1无效大图地址，0-无效地址，1-是有效大图，2-有效详情图）
        /// </summary>
        /// <param name="imageUrl">图片地址</param>
        public bool CheckImageUrl(string imageUrl)
        {
            bool result = false;
            //检查图片路径是否为空
            if (this.RegexImageUrl != null && !string.IsNullOrEmpty(imageUrl))
            {
                if (this.RegexImageUrl.IsMatch(imageUrl))
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// 开始下载图片
        /// </summary>
        /// <param name="updateLoadingState">下载过程中：更新面板状态方法</param>
        /// <returns></returns>
        public bool BeginDownLoadImage(DownloadImage downLoadImage, Action updateLoadingState)
        {
            bool downLoadResult = false;

            string[] imgArray = this.DownLoadImageUrl.Split(',');
            this.ImageTotalCount = imgArray.Length;

            updateLoadingState();

            string imgYC = "";
            DateTime now = DateTime.Now;
            foreach (var img in imgArray)
            {
                imgYC = img;
                downLoadImage.DownLoadFile(downLoadImage, imgYC, now);
                updateLoadingState();
            }

            return downLoadResult;
        }

        /// <summary>
        /// 下载网络图片到本地目录
        /// </summary>
        /// <param name="webFileUrl">网络图片地址</param>
        private void DownLoadFile(DownloadImage downLoadImage, string webFileUrl, DateTime downloadDate)
        {
            bool downLoadResult = true;
            bool isBigImage = true;

            //A-检查网络图片地址有效性
            if (false && downLoadImage.CheckImageUrl(webFileUrl) == false)
            {
                downLoadImage.ImageErrorCount++;
                downLoadImage.ImageErrorUrlList.Add(webFileUrl);
            }
            else
            {
                //B-检查大图详情图标记有效性
                string saveFilePath = "";
                string fileName = "";
                if (webFileUrl.IndexOf("?big") > -1)
                {
                    webFileUrl = webFileUrl.Replace("?big", "");
                    fileName = "大图_" + (downLoadImage.BigImageDownLoadCount + 1) + "_" + webFileUrl.Split('/').Last();
                    saveFilePath = downLoadImage.FileBigImageFilePath + fileName;
                }
                else
                {
                    isBigImage = false;
                    webFileUrl = webFileUrl.Replace("?detail", "");
                    fileName = "详情图_" + downloadDate.ToString("HHmmss") + "_" + (downLoadImage.DetailImageDownLoadCount + 1);

                    saveFilePath = $"{downLoadImage.FileDetailImageFilePath.TrimEnd('\\')}\\{fileName}.jpg";
                }

                #region 方法一：使用请求数据流下载文件
                //方法一：使用请求数据流下载文件
                WebRequest request = WebRequest.Create(webFileUrl);
                WebResponse response = null;
                try
                {
                    response = request.GetResponse();
                }
                catch (Exception e)
                {
                    //远程文件不存在
                    downLoadResult = false;
                    downLoadImage.ImageErrorCount++;
                    downLoadImage.ImageErrorUrlList.Add(webFileUrl);
                }
                if (downLoadResult && response != null)
                {
                    //下载成功

                    //获取远程读取字节流
                    Stream readStream = response.GetResponseStream();

                    //一次实际读取到的字节数
                    int readByteLength = 0;
                    byte[] readByteArray = new byte[Form1.MAX_READ_BYTE_LENGTH];
                    FileStream writer = new FileStream(saveFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                    //一次预读取100KB字节，放入字节数组中，再将实际读取的字节流写入待写入流文件中
                    while ((readByteLength = readStream.Read(readByteArray, 0, Form1.MAX_READ_BYTE_LENGTH)) > 0)
                    {
                        writer.Write(readByteArray, 0, readByteLength);
                    }
                    //释放写入流资源资源
                    writer.Close();
                    writer.Dispose();
                    //释放读取流资源
                    readStream.Close();
                    readStream.Dispose();
                    response.Close();
                    response.Dispose();

                    if (isBigImage)
                    {
                        downLoadImage.BigImageDownLoadCount++;
                        downLoadImage.BigImageDownLoadUrlList.Add(webFileUrl);
                    }
                    else
                    {
                        downLoadImage.DetailImageDownLoadCount++;
                        downLoadImage.DetailImageDownLoadUrlList.Add(webFileUrl);
                    }
                }
                #endregion

                #region 方法二：使用WebClient下载图片
                //方法二：使用WebClient下载图片
                //try
                //{
                //    Form1.WebClient.DownloadFile(webFileUrl, saveFilePath);
                //    //下载成功
                //    if (isBigImage)
                //    {
                //        downLoadImage.BigImageDownLoadCount++;
                //        downLoadImage.BigImageDownLoadUrlList.Add(webFileUrl);
                //    }
                //    else
                //    {
                //        downLoadImage.DetailImageDownLoadCount++;
                //        downLoadImage.DetailImageDownLoadUrlList.Add(webFileUrl);
                //    }
                //}
                //catch (Exception)
                //{
                //    //远程文件不存在
                //    downLoadResult = false;
                //    downLoadImage.ImageErrorCount++;
                //    downLoadImage.ImageErrorUrlList.Add(webFileUrl);
                //}

                #endregion

            }
        }


    }
}
