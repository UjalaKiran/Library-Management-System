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
    internal class Book
    {
        public DataTable GetData()
        {
            string query = "select * from Book where Status='A'";
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
        public DataTable GetData2()
        {
            string query = "select * from Book where Status='N'";
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

        public DataTable GetData3()
        {
            string query = "select * from Book";
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

        public int GetNextIssueId()
        {
            int issueId;
            String Query = "Select IsNull(max(BookId),0)+1 from Book";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Database.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            issueId = Convert.ToInt32(dt.Rows[0][0].ToString());

            return issueId;
        }

        public bool AddData(int BookId, String Bookname, string BookAuthor, decimal BookPrice, string BookPublisher)
        {
            String query = "Insert into Book values(@BookId,@Bookname,@BookAuthor,@BookPrice,@BookPublisher,@BookStatus)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@BookId", BookId);
            cmd.Parameters.AddWithValue("@BookName", Bookname);
            cmd.Parameters.AddWithValue("@BookAuthor", BookAuthor);
            cmd.Parameters.AddWithValue("@BookPrice", BookPrice);
            cmd.Parameters.AddWithValue("@BookPublisher", BookPublisher);
            cmd.Parameters.AddWithValue("@BookStatus", 'A');


            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
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

        public void ChangeStatus(int BookId)
        {
            String Query = "Update Book set Status='N' where BookId=@BookId";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            cmd.CommandType=CommandType.Text;
            cmd.Connection=Database.GetConnection();
            cmd.Parameters.AddWithValue("@BookId", BookId);
            try
            {
                int n=cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Status Updated");
                    Form1 obj = new Form1();
                    obj.FillBookIDCombo();
                }

                else
                {
                    MessageBox.Show("Status Not Updated");
                }

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ChangeStatusBack(int BookId)
        {
            String Query = "Update Book set Status='A' where BookId=@BookId";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@BookId", BookId);
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Status Updated");
                    Form1 obj = new Form1();
                    obj.FillBookIDCombo();
                }

                else
                {
                    MessageBox.Show("Status Not Updated");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
