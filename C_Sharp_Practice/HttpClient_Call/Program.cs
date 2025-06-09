using System.Net;
using System.Net.Http.Json;

namespace HttpClient_Call
{
    class Program
    {
        public static void Main(string[] args)
        {
            //WebClient wc = new WebClient();

            using (var hc = new HttpClient()) 
            {
                hc.BaseAddress = new Uri("https://localhost:44310/api/");
                var result = hc.GetAsync("student");

                var data = result.Result;

                var student = data.Content.ReadAsStringAsync();
            }
        }

        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Course { get; set; }
            public string Contact { get; set; }
        }
    }
}