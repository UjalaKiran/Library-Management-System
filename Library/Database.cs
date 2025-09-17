using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class Database
    {
            private static SqlConnection cn;
            public static SqlConnection GetConnection()
            {
                return cn;
            }
            public static void connect()
            {
                String path = @"Data Source=DESKTOP-07KKL04\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Encrypt=False";

                cn = new SqlConnection(path);
                try
                {
                    cn.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public static void disconnect()
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }
    }


