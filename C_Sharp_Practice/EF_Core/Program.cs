using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    class Program
    {
        public static void Main(string[] args) 
        {
            using (var context = new SchoolDbContext())
            {
                var students = context.Students
                  .FromSql($"Select * from Students where Name = 'Bill'")
                  .ToList();

                //Scaffold-DbContext "Server=(localdb)\\MSSQLLocalDB;Database=SchoolDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


                context.Database.EnsureCreated();
                //context.Database.BeginTransaction();

                //var grade = new Grade() { GradeName = "2st Grade" };
                //var student = new Student() { FirstName ="Abhi" ,LastName ="Niku" ,Grade = grade };

                //context.Students.Add(student);
                //context.SaveChanges();

                //foreach (var s in context.Students)
                //{
                //    Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
                //}

                Console.ReadLine();
            }
        }
    }
}