using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddNewBook : Form
    {
        private Form1 form1Instance;
        Book b = new Book();
        public AddNewBook(Form1 form1)
        {
            InitializeComponent();
            form1Instance = form1;
        }

        private void AddNewBook_Load_1(object sender, EventArgs e)
        {
            Database.connect();
            FillDGV();
            DateTime dtp = DateTime.Now;
            int issueid = b.GetNextIssueId();    // b = book issue
            txtBIId.Text = issueid.ToString();
        }

        public void FillDGV()
        {
            dgv.DataSource = b.GetData();      // dgv = data grid view
            dgv.ReadOnly = true;
            dgv.Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtBAU.Text== "")
            {
                MessageBox.Show("Book Author not Entered");
                return;
            }
            if (txtBIId.Text == "")
            {
                MessageBox.Show("Book ID not Entered");
                return;
            }
            if (txtBPRI.Text == "")
            {
                MessageBox.Show("Book Price not Entered");
                return;
            }
            if (txtBPUB.Text == "")
            {
                MessageBox.Show("Book Publisher not Entered");
                return;
            }
            if (txtBN.Text == "")
            {
                MessageBox.Show("Book Name not Entered");
                return;
            }
            int BookID;
            decimal BookPrice; 
            string BookName, BookAuthor, BookPublisher;
            BookName = Convert.ToString(txtBN.Text);
            BookID = Convert.ToInt32(txtBIId.Text);
            BookAuthor = Convert.ToString(txtBAU.Text);
            BookPublisher = Convert.ToString(txtBPUB.Text);
            BookPrice = Convert.ToDecimal(txtBPRI.Text);


            if (b.AddData(BookID, BookName, BookAuthor, BookPrice, BookPublisher))
            {
                txtBIId.Clear();
                txtBN.Clear();
                txtBAU.Clear();
                txtBPUB.Clear();
                txtBPRI.Clear();

                MessageBox.Show("Data Added Successfuly");
                FillDGV();
                int issueid = b.GetNextIssueId();
                txtBIId.Text = issueid.ToString();

                form1Instance.FillBookIDCombo();

            }
            else
            {
                MessageBox.Show("Data Can't be added");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
