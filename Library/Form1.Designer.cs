namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBIId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoll = new System.Windows.Forms.ComboBox();
            this.cmbBId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.RETURN_FORM = new System.Windows.Forms.Button();
            this.AddNewBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Issue ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBIId
            // 
            this.txtBIId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIId.Location = new System.Drawing.Point(168, 100);
            this.txtBIId.Name = "txtBIId";
            this.txtBIId.Size = new System.Drawing.Size(159, 26);
            this.txtBIId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "STUDENT NAME:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbRoll
            // 
            this.cmbRoll.FormattingEnabled = true;
            this.cmbRoll.Location = new System.Drawing.Point(577, 100);
            this.cmbRoll.Name = "cmbRoll";
            this.cmbRoll.Size = new System.Drawing.Size(159, 21);
            this.cmbRoll.TabIndex = 3;
            this.cmbRoll.SelectedIndexChanged += new System.EventHandler(this.cmbRoll_SelectedIndexChanged);
            // 
            // cmbBId
            // 
            this.cmbBId.FormattingEnabled = true;
            this.cmbBId.Location = new System.Drawing.Point(168, 155);
            this.cmbBId.Name = "cmbBId";
            this.cmbBId.Size = new System.Drawing.Size(159, 21);
            this.cmbBId.TabIndex = 5;
            this.cmbBId.SelectedIndexChanged += new System.EventHandler(this.cmbBId_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "BOOK NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Issue Date:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(303, 246);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 37);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(446, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 37);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Close";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(20, 324);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(716, 192);
            this.dgv.TabIndex = 11;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(577, 159);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(157, 20);
            this.dtpIssueDate.TabIndex = 13;
            this.dtpIssueDate.ValueChanged += new System.EventHandler(this.dtpIssueDate_ValueChanged);
            // 
            // RETURN_FORM
            // 
            this.RETURN_FORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETURN_FORM.Location = new System.Drawing.Point(597, 246);
            this.RETURN_FORM.Name = "RETURN_FORM";
            this.RETURN_FORM.Size = new System.Drawing.Size(191, 37);
            this.RETURN_FORM.TabIndex = 14;
            this.RETURN_FORM.Text = "RETURN BOOK";
            this.RETURN_FORM.UseVisualStyleBackColor = true;
            this.RETURN_FORM.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewBook
            // 
            this.AddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBook.Location = new System.Drawing.Point(20, 246);
            this.AddNewBook.Name = "AddNewBook";
            this.AddNewBook.Size = new System.Drawing.Size(191, 37);
            this.AddNewBook.TabIndex = 15;
            this.AddNewBook.Text = "ADD NEW BOOK";
            this.AddNewBook.UseVisualStyleBackColor = true;
            this.AddNewBook.Click += new System.EventHandler(this.AddNewBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 37);
            this.label5.TabIndex = 31;
            this.label5.Text = "WELCOME TO \"LIBRARY\" ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddNewBook);
            this.Controls.Add(this.RETURN_FORM);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRoll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBIId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBIId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoll;
        private System.Windows.Forms.ComboBox cmbBId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button RETURN_FORM;
        private System.Windows.Forms.Button AddNewBook;
        private System.Windows.Forms.Label label5;
    }
}

