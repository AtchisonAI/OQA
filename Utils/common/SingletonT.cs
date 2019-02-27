namespace Utils
{
    /// <summary>
    /// 泛型单例类，可为所有带无参数构造函数的类提供单例模式
    /// </summary>
    /// <typeparam name="T">需要实现单例的类</typeparam>
    public class SingletonT<T> where T : new()
    {
        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }
        class SingletonCreator
        {
            internal static readonly T instance = new T();
        }
    }
}