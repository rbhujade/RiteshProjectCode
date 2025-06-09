namespace First_vs_FirstOrDefault
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Emp> list = new List<Emp>()
            {
                new Emp{Name = "Ritesh"},
                new Emp {Name = "Ritesh"}
            };

            var first = list.First();

            var firstOrDefault = list.FirstOrDefault();

            Console.ReadLine();
        }
    }

    class Emp
    {
        public string Name { get; set; }
    }
}