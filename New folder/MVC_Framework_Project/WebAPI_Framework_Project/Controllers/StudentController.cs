using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Framework_Project.Models;

namespace WebAPI_Framework_Project.Controllers
{
    
    public class StudentController : ApiController
    {
        Sample_DBEntities _db = new Sample_DBEntities();

        
        public IHttpActionResult GetAllStudent() //https://localhost:44310/api/student
        {
            List<Student> stud = new List<Student>();

            var result = _db.TB_Student.ToList();

            if(result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        public IHttpActionResult GetStudentById(int id) //https://localhost:44310/api/student?id=1
        {
            var result = _db.TB_Student.Where(w => w.ID == id);

            if(result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        public IHttpActionResult Post([FromUri] Student stud)
        {
            if (ModelState.IsValid)
            {
                _db.TB_Student.Add(new TB_Student()
                {
                    ID = stud.ID,
                    Name = stud.Name,
                    Email = stud.Email,
                    Contact = stud.Contact,
                    Course = stud.Course
                });
                _db.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        public void SQLDataCon()
        {
            string conStr = ConfigurationManager.ConnectionStrings["Sample_DBEntities"].ToString();
            using(SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand sql = new SqlCommand("select * from TB_Student",con);
                con.Open();
                SqlDataAdapter dr = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                dr.Fill(dt);
                con.Close();
            }
        }
    }
}
