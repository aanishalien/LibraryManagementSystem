using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_btn_Click(object sender, EventArgs e)
        {
            Student studentInfo = new Student();
            studentInfo.Show();
            this.Hide();
        }

      

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = true;
            addBook1.Visible = false;
            issueBook1.Visible = false;
            returnBook1.Visible = false;

            
        }

        private void Addbook_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addBook1.Visible = true;
            issueBook1.Visible = false;
            returnBook1.Visible = false;

            AddBook adBook = addBook1 as AddBook;
            if (adBook != null)
            {
                adBook.refreshData();
            }
        }
        private void Issue_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addBook1.Visible = false;
            issueBook1.Visible = true;
            returnBook1.Visible = false;

            IssueBook isbk = issueBook1 as IssueBook;
            if (isbk != null)
            {
                isbk.refreshData();
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            addBook1.Visible = false;

            issueBook1.Visible = false;
            returnBook1.Visible = true;

            ReturnBook rtbk = returnBook1 as ReturnBook;
            if (rtbk != null)
            {
                rtbk.refreshData();
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 lForm = new Form1();
                lForm.Show();
                this.Hide();
            }
        }
    }
}
