namespace Private_Constructor
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Singleton obj = Singleton.GetInstance();
            obj.ShowMessage();

            //Singleton s = new Singleton();//❌ Compilation Error: Constructor is private
        }
    }

    class Singleton
    {
        private static Singleton _instance;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Instance Accessed");
        }
    }
}