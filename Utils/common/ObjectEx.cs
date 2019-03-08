using System;
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

        public static async Task<T> RunAsync<T>(Func<T> func)
        {
            return await Task.Run(func);
        }

        public static async Task RunAsync(Action action)
        {
            await Task.Run(action);
        }

        public static void InitialObj(object dest, object sorcue)
        {
            FieldInfo[] destFieldInfo = dest.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] sourceFieldInfo = sorcue.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo sourceFiled in sourceFieldInfo)
            {
                var value = sourceFiled.GetValue(sorcue);
                if (null != value)
                {
                    foreach (FieldInfo destFiled in destFieldInfo)
                    {
                        if(destFiled.Name == sourceFiled.Name)
                        {
                            destFiled.SetValue(dest, value);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 将数据库中变量名改为驼峰命名
        /// 如 user_name 改为 UserName
        /// </summary>
        /// <param name="name">变量名</param>
        /// <returns></returns>
        public static string GenVarName(string name)
        {
            string first = name.Substring(0, 1);
            name = name.Substring(1, name.Length - 1).ToLower();
            name = first.ToUpper() + name;

            int index = name.IndexOf("_");
            while (index != -1)
            {
                if (name.Length >= index + 2)
                {
                    first = name.Substring(index + 1, 1);
                    string start = name.Substring(0, index);
                    string end = name.Substring(index + 2, name.Length - index - 2);
                    name = start + first.ToUpper() + end;

                    index = name.IndexOf("_");
                }
            }

            name = name.Replace("_", "");

            return name;
        }
    }
}