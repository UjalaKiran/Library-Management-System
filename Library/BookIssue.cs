using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Library
{
    internal class BookIssue
    {
        public DataTable GetData()
        {
            string query = "select * from BookIssue";
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

        public DataTable GetData(int BookIssueId)
        {
            string query = "select * from BookIssue where BookIssueId = @BookIssueId";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@BookIssueId", BookIssueId);
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

        public DataTable GetDataDGV()
        {
            string query = "select BookIssueId,BookIssue.BookId as Book_Purchased_Id,Title,BookIssue.RollNo as Student_Who_Purchased_Id,Name,IssueDate from BookIssue join Student on BookIssue.RollNo = Student.RollNo join Book on BookIssue.BookId = Book.BookId";
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

        public bool AddData(int BookIssueId, String RollNo, int BookId, DateTime IssueDate)
        {
            Book b=new Book();
            String query = "Insert into BookIssue(BookIssueId,RollNo,BookId,IssueDate) values(@BookIssueId,@RollNo,@BookId,@IssueDate)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@BookIssueId", BookIssueId);
            cmd.Parameters.AddWithValue("@RollNo", RollNo);
            cmd.Parameters.AddWithValue("@BookId", BookId);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            

            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                    b.ChangeStatus(BookId);
                }
                    
                else
                    success = false;
            }
            catch (SqlException ex)
            {
                success = false;
                MessageBox.Show(ex.Message);
            }
            return success;

        }

        public bool DeleteData(int BookIssueId, String RollNo, int BookId, DateTime IssueDate)
        {
            Book b = new Book();
            String query = "Delete from BookIssue where BookIssueId = @BookIssueId AND RollNo = @RollNo AND BookId = @BookId AND IssueDate = @IssueDate;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@BookIssueId", BookIssueId);
            cmd.Parameters.AddWithValue("@RollNo", RollNo);
            cmd.Parameters.AddWithValue("@BookId", BookId);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);

            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                    b.ChangeStatusBack(BookId);
                }

                else
                    success = false;
            }
            catch (SqlException ex)
            {
                success = false;
                MessageBox.Show(ex.Message);
            }
            return success;

        }

        public int GetNextIssueId()
        {
            int issueId;
            String Query = "Select IsNull(max(BookIssueId),0)+1 from BookIssue";
            SqlDataAdapter adapter=new SqlDataAdapter(Query,Database.GetConnection());
            DataTable dt=new DataTable();
                adapter.Fill(dt);
                 issueId = Convert.ToInt32(dt.Rows[0][0].ToString());
            
            return issueId;
        }

    }
}
