using NPoco;
using WcfService;

using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace OQAService.Services
{
    public class OQABaseService: BaseService
    {

        
        public OQABaseService():base("OQADB")
        {

        }

        //public IDatabase db;

        //private IDatabase GetDb()
        //{
        //    return db;
        //}
        public static void InitTable( object sorcue)
        {
            FieldInfo[] sourceFieldInfo = sorcue.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo sourceFiled in sourceFieldInfo)
            {
                var value = sourceFiled.GetValue(sorcue);
                if (null == value)
                {
                    if (sourceFiled.FieldType == typeof(String))
                    {
                        sourceFiled.SetValue(sorcue, " ");
                    }
                    else
                    {
                        sourceFiled.SetValue(sorcue, 0);
                    }

                }
            }
        }


        public string GetSysTime()
        {
            string result = DateTime.Now.ToString("yyyyMMddhhmmss");
            return result;
        }

        /// <summary>

        /// 将Base64字符串转换为图片

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>

        public string SavePic(string transferPic, string picID)
        {
            string base64 = transferPic;

            byte[] bytes = Convert.FromBase64String(base64);

            MemoryStream memStream = new MemoryStream(bytes);

            Bitmap tn = new Bitmap(memStream);//创建一个位图；把ms变成图片；

            string picPath = "../" + "/OQA_Pic/" + picID + ".jpeg";

            string path = picPath.Substring(0, picPath.LastIndexOf("/"));
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            tn.Save(picPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            return picPath;
            //..//OQA_Pic/20190311104054.jpeg

        }



        public Stream GetPic(string sPath)
        {
            MemoryStream ms = new MemoryStream();
            FileStream fs = new FileStream(sPath, FileMode.Open, FileAccess.Read);//创建一个文件，并把文件放在文件流里边；
            fs.Position = 0;//指明从第0位开始拷贝
            fs.CopyTo(ms);
            ms.Position = 0;//注意如果缺少该条代码接收端将无法显示上传图片
            return ms;//然后在返回客户端；

        }
    }
}
