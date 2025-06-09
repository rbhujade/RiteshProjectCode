using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO_Dot_Net
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //SqlDataReader_Architecture();
            SqlDataAdapter__Architecture();
        }

        //Connected Architecture (SqlDataReader)
        public static void SqlDataReader_Architecture()
        {
            string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=Sample_DB;";//Integrated Security=True;Trusted_Connection=True;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "select * from TB_Employee";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Console.WriteLine("ID : " + sdr["ID"] + "    Name : " + sdr["Name"]);
                }

                con.Close();
            }
        }

        //Using Disconnected Architecture (DataSet)
        public static void SqlDataAdapter__Architecture()
        {
            string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=Sample_DB;";//Integrated Security=True;Trusted_Connection=True;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "select * from TB_Employee";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,con);

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet);

                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine("ID : " + item["ID"] + "  Name : " + item["Name"]);
                }
            }
        }
    }
}