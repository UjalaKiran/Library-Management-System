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
    public partial class Form1 : Form
    {
        Student s = new Student();
        Book b=new Book();
        BookIssue bi=new BookIssue();
        bool starting = false;
        String Date;
        String BookID="", RollNo="";
        List<int> changed_status_books = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.connect();
            FillRollNoCombo();
            FillBookIDCombo();
            FillDGV();
            DateTime dtp = DateTime.Now;
           int issueid= bi.GetNextIssueId();    // bi = book issue
            txtBIId.Text = issueid.ToString();
        }

        public void FillDGV()
        {
            dgv.DataSource=bi.GetDataDGV();      // dgv = data grid view
            dgv.ReadOnly = true;
            dgv.Refresh();
        }

        public void FillBookIDCombo()
        {
            cmbBId.DataSource = b.GetData();    // cmbBId= combo box books id
            cmbBId.DisplayMember = "Title";
            cmbBId.ValueMember = "BookId";
            cmbBId.Text = string.Empty;
        }

        private void FillRollNoCombo()
        {
            var data = s.GetData(); // Ensure this returns data
            if (data.Rows.Count > 0)
            {
                cmbRoll.DataSource = data;
                cmbRoll.DisplayMember = "Name";  // Name column from the Student table
                cmbRoll.ValueMember = "RollNo";  // RollNo column from the Student table
                cmbRoll.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No students found in the database.");
            }
        }

        public void RefreshDGV()
        {
            dgv.Refresh();

        }

        private void cmbBId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (starting != true)
            {
                    BookID = cmbBId.SelectedValue.ToString();
            }
        }

       private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbRoll.SelectedValue == "")
            {
                MessageBox.Show("Roll No not Entered");
                return;
            }
            if (cmbBId.SelectedValue == "")
            {
                MessageBox.Show("Book ID not Entered");
                return;
            }
            if (txtBIId.Text == "")
            {
                MessageBox.Show("Book Issue ID not Entered");
                return;
            }
            int BookIssueID,BookID;
            DateTime issueDate = dtpIssueDate.Value;   //dtpIssueDate = Issue Date, Date time picker
            RollNo = Convert.ToString(cmbRoll.SelectedValue);
            BookID = Convert.ToInt32(cmbBId.SelectedValue.ToString());
            BookIssueID = Convert.ToInt32(txtBIId.Text);
            if(bi.AddData(BookIssueID,RollNo, BookID, issueDate))
            {
                txtBIId.Clear();
                cmbBId.Text = string.Empty;
                cmbRoll.Text = string.Empty;
                MessageBox.Show("Data Added Successfuly");
                FillDGV();
                FillRollNoCombo();
                FillBookIDCombo();
                int issueid = bi.GetNextIssueId();
                txtBIId.Text = issueid.ToString();
                changed_status_books.Add(BookID);
            }
            else
            {
                MessageBox.Show("Data Can't be added");
            }

        }

        private void DisplayBookIssueData()
        {

        }

        private void cmbRoll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (starting != true)
            {
                RollNo = cmbRoll.SelectedValue.ToString();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            //int size = changed_status_books.Count;

            //for (int i = 0; i < size; i++)
            //{
            //    b.ChangeStatusBack(changed_status_books[i]);
            //}

            Database.disconnect();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new ReturnBook(this);
            newform.Show();

        }

        private void AddNewBook_Click(object sender, EventArgs e)
        {
            var addbook = new AddNewBook(this);
            addbook.Show();
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
          //  Date=dtpIssueDate.Value.ToString();
        }
    }
}
