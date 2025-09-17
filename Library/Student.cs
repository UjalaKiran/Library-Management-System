using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class Student
    {
        public DataTable GetData()
        {
            string query = "select * from Student";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Database.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                Console.WriteLine("Rows fetched: " + dt.Rows.Count); // Debug line
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        public DataTable GetData2()      // It is that function which we call in form1.cs file with the object named for Student class
        {
            string query = "select Name,BookIssue.RollNo from BookIssue join Student on BookIssue.RollNo = Student.RollNo";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Database.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}