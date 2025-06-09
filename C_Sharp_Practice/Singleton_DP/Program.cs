namespace Singleton_DP
{
    class Program
    {
        public static void Main(string[] args) 
        {
            MySingleton singleton = MySingleton.GetInstance;
            Singleton singleton1 = Singleton.GetInstance;
            singleton.Print("Call Singleton ");
        }
    }
}