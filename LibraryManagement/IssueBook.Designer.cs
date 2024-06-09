namespace LibraryManagement
{
    partial class IssueBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookissue_clear = new System.Windows.Forms.Button();
            this.bookissue_delete = new System.Windows.Forms.Button();
            this.bookissue_update = new System.Windows.Forms.Button();
            this.bookissue_add = new System.Windows.Forms.Button();
            this.bookissue_returndate = new System.Windows.Forms.DateTimePicker();
            this.bookissue_issuedate = new System.Windows.Forms.DateTimePicker();
            this.bookissue_picturebox = new System.Windows.Forms.PictureBox();
            this.issue_bktitle = new System.Windows.Forms.ComboBox();
            this.issuebook_status = new System.Windows.Forms.ComboBox();
            this.bookissue_author = new System.Windows.Forms.ComboBox();
            this.bookissue_email = new System.Windows.Forms.TextBox();
            this.bookissue_cno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bookissue_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bookissue_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookissue_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 265);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 204);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Issue Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.bookissue_clear);
            this.panel2.Controls.Add(this.bookissue_delete);
            this.panel2.Controls.Add(this.bookissue_update);
            this.panel2.Controls.Add(this.bookissue_add);
            this.panel2.Controls.Add(this.bookissue_returndate);
            this.panel2.Controls.Add(this.bookissue_issuedate);
            this.panel2.Controls.Add(this.bookissue_picturebox);
            this.panel2.Controls.Add(this.issue_bktitle);
            this.panel2.Controls.Add(this.issuebook_status);
            this.panel2.Controls.Add(this.bookissue_author);
            this.panel2.Controls.Add(this.bookissue_email);
            this.panel2.Controls.Add(this.bookissue_cno);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bookissue_name);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.bookissue_ID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(35, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 248);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // bookissue_clear
            // 
            this.bookissue_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bookissue_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookissue_clear.Location = new System.Drawing.Point(570, 207);
            this.bookissue_clear.Name = "bookissue_clear";
            this.bookissue_clear.Size = new System.Drawing.Size(100, 29);
            this.bookissue_clear.TabIndex = 7;
            this.bookissue_clear.Text = "Clear";
            this.bookissue_clear.UseVisualStyleBackColor = false;
            this.bookissue_clear.Click += new System.EventHandler(this.Bookissue_clear_Click);
            // 
            // bookissue_delete
            // 
            this.bookissue_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bookissue_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookissue_delete.Location = new System.Drawing.Point(406, 207);
            this.bookissue_delete.Name = "bookissue_delete";
            this.bookissue_delete.Size = new System.Drawing.Size(100, 29);
            this.bookissue_delete.TabIndex = 7;
            this.bookissue_delete.Text = "Delete";
            this.bookissue_delete.UseVisualStyleBackColor = false;
            this.bookissue_delete.Click += new System.EventHandler(this.Bookissue_delete_Click);
            // 
            // bookissue_update
            // 
            this.bookissue_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bookissue_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookissue_update.Location = new System.Drawing.Point(262, 207);
            this.bookissue_update.Name = "bookissue_update";
            this.bookissue_update.Size = new System.Drawing.Size(100, 29);
            this.bookissue_update.TabIndex = 7;
            this.bookissue_update.Text = "Update";
            this.bookissue_update.UseVisualStyleBackColor = false;
            this.bookissue_update.Click += new System.EventHandler(this.Bookissue_update_Click);
            // 
            // bookissue_add
            // 
            this.bookissue_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bookissue_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookissue_add.Location = new System.Drawing.Point(123, 207);
            this.bookissue_add.Name = "bookissue_add";
            this.bookissue_add.Size = new System.Drawing.Size(100, 29);
            this.bookissue_add.TabIndex = 7;
            this.bookissue_add.Text = "Add";
            this.bookissue_add.UseVisualStyleBackColor = false;
            this.bookissue_add.Click += new System.EventHandler(this.Bookissue_add_Click);
            // 
            // bookissue_returndate
            // 
            this.bookissue_returndate.Location = new System.Drawing.Point(416, 132);
            this.bookissue_returndate.Name = "bookissue_returndate";
            this.bookissue_returndate.Size = new System.Drawing.Size(168, 20);
            this.bookissue_returndate.TabIndex = 6;
            // 
            // bookissue_issuedate
            // 
            this.bookissue_issuedate.Location = new System.Drawing.Point(416, 93);
            this.bookissue_issuedate.Name = "bookissue_issuedate";
            this.bookissue_issuedate.Size = new System.Drawing.Size(168, 20);
            this.bookissue_issuedate.TabIndex = 6;
            // 
            // bookissue_picturebox
            // 
            this.bookissue_picturebox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bookissue_picturebox.Location = new System.Drawing.Point(616, 20);
            this.bookissue_picturebox.Name = "bookissue_picturebox";
            this.bookissue_picturebox.Size = new System.Drawing.Size(116, 119);
            this.bookissue_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookissue_picturebox.TabIndex = 5;
            this.bookissue_picturebox.TabStop = false;
            // 
            // issue_bktitle
            // 
            this.issue_bktitle.FormattingEnabled = true;
            this.issue_bktitle.Location = new System.Drawing.Point(416, 10);
            this.issue_bktitle.Name = "issue_bktitle";
            this.issue_bktitle.Size = new System.Drawing.Size(168, 21);
            this.issue_bktitle.TabIndex = 4;
            this.issue_bktitle.SelectedIndexChanged += new System.EventHandler(this.Issue_bktitle_SelectedIndexChanged);
            // 
            // issuebook_status
            // 
            this.issuebook_status.FormattingEnabled = true;
            this.issuebook_status.Items.AddRange(new object[] {
            "Return",
            "Not Return"});
            this.issuebook_status.Location = new System.Drawing.Point(416, 158);
            this.issuebook_status.Name = "issuebook_status";
            this.issuebook_status.Size = new System.Drawing.Size(168, 21);
            this.issuebook_status.TabIndex = 3;
            // 
            // bookissue_author
            // 
            this.bookissue_author.FormattingEnabled = true;
            this.bookissue_author.Location = new System.Drawing.Point(416, 50);
            this.bookissue_author.Name = "bookissue_author";
            this.bookissue_author.Size = new System.Drawing.Size(168, 21);
            this.bookissue_author.TabIndex = 3;
            // 
            // bookissue_email
            // 
            this.bookissue_email.Location = new System.Drawing.Point(123, 133);
            this.bookissue_email.Name = "bookissue_email";
            this.bookissue_email.Size = new System.Drawing.Size(168, 20);
            this.bookissue_email.TabIndex = 2;
            // 
            // bookissue_cno
            // 
            this.bookissue_cno.Location = new System.Drawing.Point(123, 97);
            this.bookissue_cno.Name = "bookissue_cno";
            this.bookissue_cno.Size = new System.Drawing.Size(168, 20);
            this.bookissue_cno.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Return";
            this.label9.Click += new System.EventHandler(this.Label8_Click);
            // 
            // bookissue_name
            // 
            this.bookissue_name.Location = new System.Drawing.Point(123, 55);
            this.bookissue_name.Name = "bookissue_name";
            this.bookissue_name.Size = new System.Drawing.Size(168, 20);
            this.bookissue_name.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Issue";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Status";
            // 
            // bookissue_ID
            // 
            this.bookissue_ID.Location = new System.Drawing.Point(123, 16);
            this.bookissue_ID.Name = "bookissue_ID";
            this.bookissue_ID.Size = new System.Drawing.Size(168, 20);
            this.bookissue_ID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Book Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contact No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Issue ID:";
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBook";
            this.Size = new System.Drawing.Size(802, 593);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookissue_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox bookissue_email;
        private System.Windows.Forms.TextBox bookissue_cno;
        private System.Windows.Forms.TextBox bookissue_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bookissue_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bookissue_clear;
        private System.Windows.Forms.Button bookissue_delete;
        private System.Windows.Forms.Button bookissue_update;
        private System.Windows.Forms.Button bookissue_add;
        private System.Windows.Forms.DateTimePicker bookissue_returndate;
        private System.Windows.Forms.DateTimePicker bookissue_issuedate;
        private System.Windows.Forms.PictureBox bookissue_picturebox;
        private System.Windows.Forms.ComboBox issue_bktitle;
        private System.Windows.Forms.ComboBox bookissue_author;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox issuebook_status;
        private System.Windows.Forms.Label label10;
    }
}
