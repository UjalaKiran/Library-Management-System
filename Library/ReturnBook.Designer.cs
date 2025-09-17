namespace Library
{
    partial class ReturnBook
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
            this.btnClear2 = new System.Windows.Forms.Button();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBId2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRoll2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBIId = new System.Windows.Forms.ComboBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Return_Book = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear2
            // 
            this.btnClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.Location = new System.Drawing.Point(848, 321);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(121, 46);
            this.btnClear2.TabIndex = 11;
            this.btnClear2.Text = "Close";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(795, 228);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(208, 22);
            this.dtpIssueDate.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Issue Date:";
            // 
            // cmbBId2
            // 
            this.cmbBId2.FormattingEnabled = true;
            this.cmbBId2.Location = new System.Drawing.Point(249, 223);
            this.cmbBId2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBId2.Name = "cmbBId2";
            this.cmbBId2.Size = new System.Drawing.Size(211, 24);
            this.cmbBId2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "BOOK NAME:";
            // 
            // cmbRoll2
            // 
            this.cmbRoll2.FormattingEnabled = true;
            this.cmbRoll2.Location = new System.Drawing.Point(795, 155);
            this.cmbRoll2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoll2.Name = "cmbRoll2";
            this.cmbRoll2.Size = new System.Drawing.Size(211, 24);
            this.cmbRoll2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "STUDENT NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Book Issue ID:";
            // 
            // cmdBIId
            // 
            this.cmdBIId.FormattingEnabled = true;
            this.cmdBIId.Location = new System.Drawing.Point(249, 154);
            this.cmdBIId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBIId.Name = "cmdBIId";
            this.cmdBIId.Size = new System.Drawing.Size(211, 24);
            this.cmdBIId.TabIndex = 22;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(68, 395);
            this.dgv2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.Size = new System.Drawing.Size(955, 236);
            this.dgv2.TabIndex = 23;
            // 
            // Return_Book
            // 
            this.Return_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Book.Location = new System.Drawing.Point(147, 321);
            this.Return_Book.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return_Book.Name = "Return_Book";
            this.Return_Book.Size = new System.Drawing.Size(215, 46);
            this.Return_Book.TabIndex = 24;
            this.Return_Book.Text = "Return Book";
            this.Return_Book.UseVisualStyleBackColor = true;
            this.Return_Book.Click += new System.EventHandler(this.Return_Book_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(748, 46);
            this.label5.TabIndex = 31;
            this.label5.Text = "WELCOME TO \"RETURN BOOK\" PAGE";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 646);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Return_Book);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.cmdBIId);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBId2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRoll2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBId2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRoll2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdBIId;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button Return_Book;
        private System.Windows.Forms.Label label5;
    }
}