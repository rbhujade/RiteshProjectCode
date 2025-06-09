using static LINQ_Join.Program;

namespace LINQ_Join
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Join_LINQ join_LINQ = new Join_LINQ();
            join_LINQ.LeftJoin();

            GroupBy();
            SingleOrDefault();
            FirstOrDefault();
            ElementAt();
            InnerJoin();

            IList<string> list = new List<string>(){
                "one","two","three","four"
            };

            IList<string> list2 = new List<string>(){
                "one","two","five","six","seven"
            };


            var innerJoin = list.Join(list2,l1=>l1,l2=>l2,(l1,l2)=>l1);

        }

        public static void GroupBy()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            var result = from s in studentList
                         where s.StudentID > 0
                         group s by s.StandardID into g
                         select new {g.Key};

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }

        public static void SingleOrDefault()
        {
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            var single = oneElementList.Single();
            //var single2 = intList.Single(); //Error - Sequence contains more than one element
            //var single3 = strList.Single(); //Error - Sequence contains more than one element
            //var single4 = emptyList.Single(); //Error - Sequence contains no elements

            var single5 = oneElementList.SingleOrDefault();
            //var single6 = intList.SingleOrDefault(); //Error - 'Sequence contains more than one element'
            //var single7 = strList.SingleOrDefault(); //Error - 'Sequence contains more than one element'
            var single8 = emptyList.SingleOrDefault();
        }

        public static void FirstOrDefault()
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            var first = intList.First();
            var second = strList.First();
            //var third = emptyList.First(); //error

            var third = intList.FirstOrDefault();
            var fourth = strList.FirstOrDefault();
            var fifth = emptyList.FirstOrDefault();
        }

        public static void ElementAt()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            var element = intList.ElementAt(0);
            var element2 = strList.ElementAt(0);

            var element3 = intList.ElementAt(1);
            var element4 = strList.ElementAt(1);

            var element5 = intList.ElementAtOrDefault(6);
            var element6 = strList.ElementAtOrDefault(6);

        }

        public static void InnerJoin()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            //method syntax
            var joinResult = studentList.Join(standardList,
                student => student.StandardID,
                standard => standard.StandardID,
                (student,standard) => new
                {
                    StudentName = student.StudentName,
                    StandardID = standard.StandardID,
                });

            //query syntax
            var querySyntax = from s in studentList
                              join sd in standardList
                              on s.StandardID equals sd.StandardID
                              select new
                              {
                                  StudentName=s.StudentName,
                                  StudentID=s.StudentID,
                                  StandardID=s.StandardID,
                                  StandardName=sd.StandardName
                              };

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item.StudentName + "----" + item.StudentID + "---"+ item.StandardID + "----" + item.StandardName);
            }
            //Console.ReadLine();

            //join
            var innerJoin = from t1 in studentList
                      join t2 in standardList on t1.StandardID equals t2.StandardID
                      select new
                      {
                          t1.StudentName,
                          t2.StandardName
                      };

            var innerJoinMethod = studentList.Join(standardList,
                student => student.StandardID,
                standard => standard.StandardID,
                (student, standard) => new { 
                    Name = student.StudentName,
                    StandardName = standard.StandardName
                });

            //left join
            var leftJoin = from t1 in studentList
                           join t2 in standardList
                           on t1.StandardID equals t2.StandardID into gj
                           from subGroup in gj.DefaultIfEmpty()
                           select new
                           {
                               t1.StudentName,
                               t1.StudentID,
                               StandardName = subGroup.StandardName ?? string.Empty
                           };

        }

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int StandardID { get; set; }
        }
        public class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }
    }
}