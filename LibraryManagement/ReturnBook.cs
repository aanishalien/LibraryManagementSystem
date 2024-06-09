using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class ReturnBook : UserControl
    {

        SqlConnection conn =
         new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gadget Fix\source\repos\LibraryManagement\LibraryManagement\librarymanagement.mdf;Integrated Security=True;Connect Timeout=30");
        public ReturnBook()
        {
            InitializeComponent();

            displayIssuedBooksData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssuedBooksData();
            
        }

        private void Returnbook_btn_Click(object sender, EventArgs e)
        {
            if (returnbooks_issueID.Text == ""
                || returnbook_name.Text == ""
                || returnbook_cno.Text == ""
                || returnbook_email.Text == ""
                || returnbook_bktitle.Text == ""
                || returnbook_author.Text == ""
                || bookissued_date.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    DialogResult check = MessageBox.Show("Are you sure that Issue ID: "
                        + returnbooks_issueID.Text.Trim()
                        + "is return already?", "Confirmation Message", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            conn.Open();

                            string updateData = "UPDATE issues SET status = @status, date_update = @dateUpdate " +
                                "WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", returnbooks_issueID.Text);

                                cmd.ExecuteNonQuery();

                                displayIssuedBooksData();

                                MessageBox.Show("Returned successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }

                }
            }
        }
        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.IssueBooksData();

            dataGridView1.DataSource = listData;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnbooks_issueID.Text = row.Cells[1].Value.ToString();
                returnbook_name.Text = row.Cells[2].Value.ToString();
                returnbook_cno.Text = row.Cells[3].Value.ToString();
                returnbook_email.Text = row.Cells[4].Value.ToString();
                returnbook_bktitle.Text = row.Cells[5].Value.ToString();
                returnbook_author.Text = row.Cells[6].Value.ToString();
                bookissued_date.Text = row.Cells[7].Value.ToString();

            }
        }
        public void clearFields()
        {
            returnbooks_issueID.Text = "";
            returnbook_name.Text = "";
            returnbook_cno.Text = "";
            returnbook_email.Text = "";
            returnbook_bktitle.Text = "";
            returnbook_author.Text = "";
            returnbook_picture.Image = null;
        }

        private void Returnbook_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
