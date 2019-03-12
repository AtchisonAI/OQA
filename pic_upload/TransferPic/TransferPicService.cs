using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Drawing;

namespace TransferPic
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class TransferPicService : ITransferPicService
    {
        public static Stream PicSource = new MemoryStream();

        /// <summary>
        /// 从服务端下载图片到本地 （上传和下载都是拷贝的过程）
        /// </summary>
        /// <returns></returns>
        public Stream GetPic(string sPath)
        {           
           MemoryStream ms = new MemoryStream();
            FileStream fs = new FileStream(sPath, FileMode.Open, FileAccess.Read);//创建一个文件，并把文件放在文件流里边；
            fs.Position = 0;//指明从第0位开始拷贝
            fs.CopyTo(ms);
            ms.Position = 0;//注意如果缺少该条代码接收端将无法显示上传图片
            return ms;//然后在返回客户端；

            //Bitmap tn = new Bitmap(ms);//创建一个位图；把ms变成图片；
            //pictureBox1.Image = tn;
        }
        /// <summary>
        /// 从客户端上传图片到服务端（将客户端的Stream拷贝给服务端的Stream）
        /// </summary>
        /// <param name="transferPic"></param>
        public string SendPic(Stream transferPic)
        {
            //PicSource.Position = 0;
            //transferPic.CopyTo(PicSource);

            string picID = DateTime.Now.ToString("yyyyMMddhhmmss");

            Bitmap tn = new Bitmap(transferPic);//创建一个位图；把ms变成图片；

            string picPath = "../" + "/OQA_Pic/" + picID+".jpeg";

            string path = picPath.Substring(0, picPath.LastIndexOf("/"));
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            tn.Save(picPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            return picPath;
            //..//OQA_Pic/20190311104054.jpeg
            // File.Copy(picID, Application.StartupPath + "\\Image\\" + id + ".jpg");

        }



    }
}
