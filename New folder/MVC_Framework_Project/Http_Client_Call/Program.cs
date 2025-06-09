using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Http_Client_Call
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var hc= new HttpClient())
            {
                hc.BaseAddress = new Uri("https://localhost:44310/api/");
                var response = hc.GetAsync("student");

                var result = response.Result;

                var data = result.Content.ReadAsStringAsync();
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
