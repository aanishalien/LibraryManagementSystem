namespace LibraryManagement
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.issue_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.addbook_btn = new System.Windows.Forms.Button();
            this.issueBook1 = new LibraryManagement.IssueBook();
            this.addBook1 = new LibraryManagement.AddBook();
            this.returnBook1 = new LibraryManagement.ReturnBook();
            this.dashboard2 = new LibraryManagement.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // exit_btn
            // 
            this.exit_btn.AutoSize = true;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(917, 17);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(14, 16);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "x";
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.return_btn);
            this.panel2.Controls.Add(this.issue_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.addbook_btn);
            this.panel2.Location = new System.Drawing.Point(2, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 596);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(35, 552);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(59, 24);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "LogOut";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Location = new System.Drawing.Point(21, 305);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(95, 33);
            this.return_btn.TabIndex = 0;
            this.return_btn.Text = "Return Books";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // issue_btn
            // 
            this.issue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_btn.Location = new System.Drawing.Point(21, 237);
            this.issue_btn.Name = "issue_btn";
            this.issue_btn.Size = new System.Drawing.Size(95, 33);
            this.issue_btn.TabIndex = 0;
            this.issue_btn.Text = "Issue Books";
            this.issue_btn.UseVisualStyleBackColor = true;
            this.issue_btn.Click += new System.EventHandler(this.Issue_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Location = new System.Drawing.Point(21, 108);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(95, 33);
            this.dashboard_btn.TabIndex = 0;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // addbook_btn
            // 
            this.addbook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbook_btn.Location = new System.Drawing.Point(21, 169);
            this.addbook_btn.Name = "addbook_btn";
            this.addbook_btn.Size = new System.Drawing.Size(95, 33);
            this.addbook_btn.TabIndex = 0;
            this.addbook_btn.Text = "Add Book";
            this.addbook_btn.UseVisualStyleBackColor = true;
            this.addbook_btn.Click += new System.EventHandler(this.Addbook_btn_Click);
            // 
            // issueBook1
            // 
            this.issueBook1.Location = new System.Drawing.Point(158, 60);
            this.issueBook1.Name = "issueBook1";
            this.issueBook1.Size = new System.Drawing.Size(793, 593);
            this.issueBook1.TabIndex = 4;
            // 
            // addBook1
            // 
            this.addBook1.Location = new System.Drawing.Point(158, 60);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(793, 596);
            this.addBook1.TabIndex = 3;
            // 
            // returnBook1
            // 
            this.returnBook1.Location = new System.Drawing.Point(158, 60);
            this.returnBook1.Name = "returnBook1";
            this.returnBook1.Size = new System.Drawing.Size(793, 595);
            this.returnBook1.TabIndex = 5;
            // 
            // dashboard2
            // 
            this.dashboard2.Location = new System.Drawing.Point(158, 58);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(793, 595);
            this.dashboard2.TabIndex = 6;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 654);
            this.Controls.Add(this.dashboard2);
            this.Controls.Add(this.returnBook1);
            this.Controls.Add(this.issueBook1);
            this.Controls.Add(this.addBook1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button issue_btn;
        private System.Windows.Forms.Button addbook_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private AddBook addBook1;
        private IssueBook issueBook1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReturnBook returnBook1;
        private Dashboard dashboard2;
        private System.Windows.Forms.Label exit_btn;
    }
}