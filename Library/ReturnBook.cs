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
    public partial class ReturnBook : Form
    {
        //Form1 form1 = new Form1();
        private Form1 form1Instance;
        Student s = new Student();
        Book b = new Book();
        BookIssue bi = new BookIssue();
        String BookID = "", RollNo = "";

        public ReturnBook(Form1 form1)
        {
            InitializeComponent();
            form1Instance = form1;
        }

        private void ReturnBook_Load_1(object sender, EventArgs e)
        {
            Database.connect();
            FillRollNoCombo();
            FillBookIDCombo();
            FillBookIssueIdCombo();
            FillDGV();
            DateTime dtp = DateTime.Now;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            form1Instance.FillDGV();
            this.Close();
        }

        private void FillDGV()
        {
            dgv2.DataSource = bi.GetDataDGV();        // dgv = data grid view
            dgv2.ReadOnly = true;
            dgv2.Refresh();
        }

        public void FillBookIDCombo()
        {
            cmbBId2.DataSource = b.GetData2();    // cmbBId= combo box books id
            cmbBId2.DisplayMember = "Title";
            cmbBId2.ValueMember = "BookId";
            cmbBId2.Text = string.Empty;
        }

        private void FillRollNoCombo()
        {
            cmbRoll2.DataSource = s.GetData2();   // cmbRoll = combo box Roll
            cmbRoll2.DisplayMember = "Name";
            cmbRoll2.ValueMember = "RollNo";
            cmbRoll2.Text = string.Empty;
        }

        private void FillBookIssueIdCombo()
        {
            cmdBIId.DataSource = bi.GetData();   // cmbRoll = combo box Roll
            cmdBIId.DisplayMember = "BookIsuueId";
            cmdBIId.ValueMember = "BookIssueId";
            cmdBIId.Text = string.Empty;
        }

        private void Return_Book_Click(object sender, EventArgs e)
        {
            if (cmbRoll2.SelectedValue == "")
            {
                MessageBox.Show("Roll No not Entered");
                return;
            }
            if (cmbBId2.SelectedValue == "")
            {
                MessageBox.Show("Book ID not Entered");
                return;
            }
            if (cmdBIId.SelectedValue == "")
            {
                MessageBox.Show("Book Issue ID not Entered");
                return;
            }
            int BookIssueID, BookID;
            DateTime issueDate = dtpIssueDate.Value.Date;   //dtpIssueDate = Issue Date, Date time picker
            if (cmbRoll2.SelectedValue == null)
            {
                MessageBox.Show("Roll No not selected");
                return;
            }
            if (cmbBId2.SelectedValue == null)
            {
                MessageBox.Show("Book ID not selected");
                return;
            }
            if (cmdBIId.SelectedValue == null)
            {
                MessageBox.Show("Book Issue ID not selected");
                return;
            }

            RollNo = cmbRoll2.SelectedValue.ToString();
            BookID = Convert.ToInt32(cmbBId2.SelectedValue.ToString());
            BookIssueID = Convert.ToInt32(cmdBIId.SelectedValue);

            if (bi.DeleteData(BookIssueID, RollNo, BookID, issueDate))
            {
                MessageBox.Show("Book Returned Successfuly");
                FillDGV();
                cmdBIId.Text = string.Empty;
                cmbBId2.Text = string.Empty;
                cmbRoll2.Text = string.Empty;

                FillBookIDCombo();
                FillBookIssueIdCombo();
                FillRollNoCombo();
            }
            else
            {
                MessageBox.Show("Book Can`t be Returned");
            }
        }
    }
}
