namespace LibraryManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookissued_date = new System.Windows.Forms.DateTimePicker();
            this.returnbook_clear = new System.Windows.Forms.Button();
            this.returnbook_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.returnbook_author = new System.Windows.Forms.TextBox();
            this.returnbook_bktitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.returnbook_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.returnbook_cno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.returnbook_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnbooks_issueID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnbook_picture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnbook_picture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.bookissued_date);
            this.panel1.Controls.Add(this.returnbook_clear);
            this.panel1.Controls.Add(this.returnbook_btn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.returnbook_author);
            this.panel1.Controls.Add(this.returnbook_bktitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.returnbook_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.returnbook_cno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.returnbook_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.returnbooks_issueID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.returnbook_picture);
            this.panel1.Location = new System.Drawing.Point(15, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 553);
            this.panel1.TabIndex = 0;
            // 
            // bookissued_date
            // 
            this.bookissued_date.Location = new System.Drawing.Point(124, 408);
            this.bookissued_date.Name = "bookissued_date";
            this.bookissued_date.Size = new System.Drawing.Size(101, 20);
            this.bookissued_date.TabIndex = 6;
            // 
            // returnbook_clear
            // 
            this.returnbook_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.returnbook_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbook_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbook_clear.Location = new System.Drawing.Point(150, 499);
            this.returnbook_clear.Name = "returnbook_clear";
            this.returnbook_clear.Size = new System.Drawing.Size(75, 23);
            this.returnbook_clear.TabIndex = 4;
            this.returnbook_clear.Text = "Clear";
            this.returnbook_clear.UseVisualStyleBackColor = false;
            this.returnbook_clear.Click += new System.EventHandler(this.Returnbook_clear_Click);
            // 
            // returnbook_btn
            // 
            this.returnbook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.returnbook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbook_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbook_btn.Location = new System.Drawing.Point(41, 498);
            this.returnbook_btn.Name = "returnbook_btn";
            this.returnbook_btn.Size = new System.Drawing.Size(75, 23);
            this.returnbook_btn.TabIndex = 4;
            this.returnbook_btn.Text = "Return";
            this.returnbook_btn.UseVisualStyleBackColor = false;
            this.returnbook_btn.Click += new System.EventHandler(this.Returnbook_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Book Issued";
            // 
            // returnbook_author
            // 
            this.returnbook_author.Location = new System.Drawing.Point(124, 374);
            this.returnbook_author.Name = "returnbook_author";
            this.returnbook_author.Size = new System.Drawing.Size(100, 20);
            this.returnbook_author.TabIndex = 3;
            // 
            // returnbook_bktitle
            // 
            this.returnbook_bktitle.Location = new System.Drawing.Point(124, 335);
            this.returnbook_bktitle.Name = "returnbook_bktitle";
            this.returnbook_bktitle.Size = new System.Drawing.Size(100, 20);
            this.returnbook_bktitle.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Author";
            // 
            // returnbook_email
            // 
            this.returnbook_email.Location = new System.Drawing.Point(124, 290);
            this.returnbook_email.Name = "returnbook_email";
            this.returnbook_email.Size = new System.Drawing.Size(100, 20);
            this.returnbook_email.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Title";
            // 
            // returnbook_cno
            // 
            this.returnbook_cno.Location = new System.Drawing.Point(124, 249);
            this.returnbook_cno.Name = "returnbook_cno";
            this.returnbook_cno.Size = new System.Drawing.Size(100, 20);
            this.returnbook_cno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // returnbook_name
            // 
            this.returnbook_name.Location = new System.Drawing.Point(124, 208);
            this.returnbook_name.Name = "returnbook_name";
            this.returnbook_name.Size = new System.Drawing.Size(100, 20);
            this.returnbook_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No.";
            // 
            // returnbooks_issueID
            // 
            this.returnbooks_issueID.Location = new System.Drawing.Point(124, 167);
            this.returnbooks_issueID.Name = "returnbooks_issueID";
            this.returnbooks_issueID.Size = new System.Drawing.Size(100, 20);
            this.returnbooks_issueID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue ID";
            // 
            // returnbook_picture
            // 
            this.returnbook_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.returnbook_picture.Location = new System.Drawing.Point(52, 35);
            this.returnbook_picture.Name = "returnbook_picture";
            this.returnbook_picture.Size = new System.Drawing.Size(96, 90);
            this.returnbook_picture.TabIndex = 0;
            this.returnbook_picture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(330, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 553);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 476);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "All Issued Books";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnBook";
            this.Size = new System.Drawing.Size(773, 595);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnbook_picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button returnbook_clear;
        private System.Windows.Forms.Button returnbook_btn;
        private System.Windows.Forms.TextBox returnbook_author;
        private System.Windows.Forms.TextBox returnbook_bktitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox returnbook_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox returnbook_cno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox returnbook_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox returnbooks_issueID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox returnbook_picture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker bookissued_date;
    }
}
