namespace ExtensionMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dob = new DateTime(1995, 5, 10);
            int age = StringHelper.DateTimeExtensions(dob);
            Console.WriteLine("Age : " + age);

            string str = "ritesh";
            string result = str.ChangeFirstLetterCase();

            string result2 = StringHelper.ChangeFirstLetterCase(str);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}