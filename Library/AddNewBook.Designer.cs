namespace Library
{
    partial class AddNewBook
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBIId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBN = new System.Windows.Forms.TextBox();
            this.txtBPUB = new System.Windows.Forms.TextBox();
            this.txtBPRI = new System.Windows.Forms.TextBox();
            this.txtBAU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(29, 366);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(716, 192);
            this.dgv.TabIndex = 25;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(643, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 37);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Close";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(78, 304);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(172, 37);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Add This Book";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "PRICE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "BOOK NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "AUTHOR NAME:";
            // 
            // txtBIId
            // 
            this.txtBIId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIId.Location = new System.Drawing.Point(168, 114);
            this.txtBIId.Name = "txtBIId";
            this.txtBIId.Size = new System.Drawing.Size(159, 26);
            this.txtBIId.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "PUBLISHER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(619, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "WELCOME TO \"ADD NEW BOOK\" PAGE";
            // 
            // txtBN
            // 
            this.txtBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBN.Location = new System.Drawing.Point(168, 166);
            this.txtBN.Name = "txtBN";
            this.txtBN.Size = new System.Drawing.Size(159, 26);
            this.txtBN.TabIndex = 31;
            // 
            // txtBPUB
            // 
            this.txtBPUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPUB.Location = new System.Drawing.Point(168, 233);
            this.txtBPUB.Name = "txtBPUB";
            this.txtBPUB.Size = new System.Drawing.Size(159, 26);
            this.txtBPUB.TabIndex = 32;
            // 
            // txtBPRI
            // 
            this.txtBPRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPRI.Location = new System.Drawing.Point(586, 169);
            this.txtBPRI.Name = "txtBPRI";
            this.txtBPRI.Size = new System.Drawing.Size(159, 26);
            this.txtBPRI.TabIndex = 33;
            // 
            // txtBAU
            // 
            this.txtBAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAU.Location = new System.Drawing.Point(586, 114);
            this.txtBAU.Name = "txtBAU";
            this.txtBAU.Size = new System.Drawing.Size(159, 26);
            this.txtBAU.TabIndex = 34;
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.txtBAU);
            this.Controls.Add(this.txtBPRI);
            this.Controls.Add(this.txtBPUB);
            this.Controls.Add(this.txtBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBIId);
            this.Controls.Add(this.label1);
            this.Name = "AddNewBook";
            this.Text = "AddNewBook";
            this.Load += new System.EventHandler(this.AddNewBook_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBN;
        private System.Windows.Forms.TextBox txtBPUB;
        private System.Windows.Forms.TextBox txtBPRI;
        private System.Windows.Forms.TextBox txtBAU;
    }
}