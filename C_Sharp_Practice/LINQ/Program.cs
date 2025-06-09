namespace LINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };

            //GroupBy
            var result = from s in studentList
                         group s by s.Age;

            var result2 = studentList.GroupBy(g=> g.Age);

            var result3 = studentList.ToLookup(t => t.Age);


            string[] arr = { "Bill", "Steve", "James", "Mohan" };

            var linqResult = from i in arr
                             where i.Contains("a")
                             select i;

            foreach (var i in linqResult)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }

    }
}