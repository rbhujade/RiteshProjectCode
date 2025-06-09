namespace Const_Static_Readonly
{
    class Program
    {
        public static void Main(string[] args) 
        {
            int static1 = 111;
            Example ex = new Example(static1);
            

            //string str1 = "first";
            //string str2 = "second";
            //College college = new College(str1,str2);
            

            Console.ReadLine();
        }
    }
}