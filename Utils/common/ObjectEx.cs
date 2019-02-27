using System;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;

namespace Utils
{
    public static class ObjectEx
    {
        /// <summary>
        /// object类型的扩展方法，对自身的string类型的公开属性全部初始化为空字符串
        /// </summary>
        /// <param name="obj"></param>
        public static void InitProperties(this object obj)
        {
            PropertyInfo[] pi = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var p in pi)
            {
                if (p.PropertyType == typeof(string))
                {
                    p.SetValue(obj, "");
                }
                else if (p.PropertyType == typeof(char))
                {
                    p.SetValue(obj, ' ');
                }else if(p.PropertyType == typeof(bool))
                {
                    p.SetValue(obj, false);
                }
            }
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// 定义一个资源文件名 资源文件名 = 工程的默认命名空间+文件名(不带扩展名)
        /// </summary>
        private static string PublicResourceFileName = "CL.Resources";
        /// <summary>
        /// 从资源文件中读取一个资源 
        /// </summary>
        /// <param name="resFile">资源文件名称 命名空间+文件名称</param>
        /// <param name="resName">要读取的资源名称</param>
        /// <returns>返回一个资源 读取失败返回NULL</returns>
        public static System.Object ReadFromResourceFile(String resName)
        {
            try
            {
                Assembly myAssembly;
                myAssembly = Assembly.GetExecutingAssembly();
                System.Resources.ResourceManager rm = new
                  System.Resources.ResourceManager(PublicResourceFileName, myAssembly);
                return rm.GetObject(resName);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 获取资源图片
        /// </summary>
        /// <param name="name">文件名</param>
        /// <returns>资源图片</returns>
        public static Bitmap GetResourceImage(String name)
        {
            Object tempbitmap = null;
            tempbitmap = ReadFromResourceFile(name);
            if (tempbitmap.GetType().Equals(typeof(Bitmap)))
            {
                return (Bitmap)tempbitmap;
            }
            return null;
        }

        public static async Task<T> RunAsync<T>(Func<T> func)
        {
            return await Task.Run(func);
        }

        public static async Task RunAsync(Action action)
        {
            await Task.Run(action);
        }
    }
}