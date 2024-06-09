using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = 
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gadget Fix\source\repos\LibraryManagement\LibraryManagement\librarymanagement.mdf;Integrated Security=True;Connect Timeout=30");
        private void Student_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == ""
                || password_txt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                        string insertData = "INSERT INTO users" +
                            "(username,password)"+
                            "VALUES(@username,@password)";

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username_txt.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", password_txt.Text.Trim());

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registered successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Mainform mainform = new Mainform();
                            mainform.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }


        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            username_txt.Clear();
            password_txt.Clear();

            username_txt.Focus();
        }
    }
}
