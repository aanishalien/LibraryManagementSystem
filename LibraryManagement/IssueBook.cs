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
    public partial class IssueBook : UserControl
    {
        SqlConnection conn =
         new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gadget Fix\source\repos\LibraryManagement\LibraryManagement\librarymanagement.mdf;Integrated Security=True;Connect Timeout=30");
        public IssueBook()
        {
            InitializeComponent();

            DataBookTitle();
            displayBookIssueData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBookIssueData();
            DataBookTitle();
        }



        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
        private void displayBookIssueData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.IssueBooksData();

            dataGridView1.DataSource = listData;
        }
        private void Bookissue_add_Click(object sender, EventArgs e)
        {
            if (bookissue_ID.Text == ""
                || bookissue_name.Text == ""
                || bookissue_cno.Text == ""
                || bookissue_email.Text == ""
                || issue_bktitle.Text == ""
                || bookissue_author.Text == ""
                || bookissue_issuedate.Value == null
                || bookissue_returndate.Value == null
                || issuebook_status.Text == ""
                || bookissue_picturebox.Image == null)
            {
                MessageBox.Show("Please fill in the blank fields", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        conn.Open();

                        string insertData = "INSERT INTO issues" +
                            "(issue_id,full_name,contact,email,book_title" +
                            ",author ,status,issue_date,return_date, date_insert)" +
                            "VALUES(@issueID,@fullname,@contact,@email,@bookTitle,@author" +
                            ",@status,@issueDate ,@returnDate,@dateInsert)";

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@issueID", bookissue_ID.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullname", bookissue_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", bookissue_cno.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", bookissue_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@bookTitle", issue_bktitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", bookissue_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", issuebook_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@issueDate", bookissue_issuedate.Value);
                            cmd.Parameters.AddWithValue("@returnDate", bookissue_returndate.Value);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBookIssueData();

                            MessageBox.Show("Issued Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void clearFields()
        {
            bookissue_ID.Text = "";
            bookissue_name.Text = "";
            bookissue_cno.Text = "";
            bookissue_email.Text = "";
            issue_bktitle.SelectedIndex = -1;
            bookissue_author.SelectedIndex = -1;
            bookissue_issuedate = null;
            bookissue_returndate = null;
            issuebook_status.SelectedIndex = -1;
            bookissue_picturebox.Image = null;
        }
        private void DataBookTitle()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string selectData = "SELECT id ,book_title FROM books WHERE status = 'Available ' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        issue_bktitle.DataSource = table;
                        issue_bktitle.DisplayMember = "book_title";
                        issue_bktitle.ValueMember = "id";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void Issue_bktitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {

                if (issue_bktitle.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)issue_bktitle.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        conn.Open();

                        string selectData = "SELECT * FROM books WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(selectData, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookissue_author.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["image"].ToString();

                                if (imagePath != null)
                                {
                                    bookissue_picturebox.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    bookissue_picturebox.Image = null;
                                }
                            }

                            // Corrected line to retrieve the value from the "image" column
                            string getImage = table.Rows[0]["image"].ToString();

                            bookissue_picturebox.Image = Image.FromFile(getImage);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                bookissue_ID.Text = row.Cells[1].Value?.ToString();
                bookissue_name.Text = row.Cells[2].Value?.ToString();
                bookissue_cno.Text = row.Cells[3].Value?.ToString();
                bookissue_email.Text = row.Cells[4].Value?.ToString();
                issue_bktitle.Text = row.Cells[5].Value?.ToString();
                bookissue_author.Text = row.Cells[6].Value?.ToString();

                if (row.Cells[7].Value != null)
                {
                    bookissue_issuedate.Value = Convert.ToDateTime(row.Cells[7].Value);
                }

                if (row.Cells[8].Value != null)
                {
                    bookissue_returndate.Value = Convert.ToDateTime(row.Cells[8].Value);
                }

                issuebook_status.Text = row.Cells[9].Value?.ToString();
            }
        }


        private void Bookissue_update_Click(object sender, EventArgs e)
        {
            if (bookissue_ID.Text == ""
                || bookissue_name.Text == ""
                || bookissue_cno.Text == ""
                || bookissue_email.Text == ""
                || issue_bktitle.Text == ""
                || bookissue_author.Text == ""
                || bookissue_issuedate.Value == null
                || bookissue_returndate.Value == null
                || issuebook_status.Text == ""
                || bookissue_picturebox.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(conn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE issue ID:"
                        + bookissue_ID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET full_name = @fullName, contact = @contact , email = @email,book_title = @bookTitle,author=@author , status =@status, issue_date =@issueDate , return_date = @returnDate,date_update = @dateupdate WHERE issue_id =@issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {
                                
                                cmd.Parameters.AddWithValue("@fullname", bookissue_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", bookissue_cno.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", bookissue_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@bookTitle", issue_bktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", bookissue_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", issuebook_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@issueDate", bookissue_issuedate.Value);
                                cmd.Parameters.AddWithValue("@returnDate", bookissue_returndate.Value);
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", bookissue_ID.Text.Trim());

                                cmd.ExecuteNonQuery();
                                displayBookIssueData();
                                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void Bookissue_delete_Click(object sender, EventArgs e)
        {
            if (bookissue_ID.Text == ""
                || bookissue_name.Text == ""
                || bookissue_cno.Text == ""
                || bookissue_email.Text == ""
                || issue_bktitle.Text == ""
                || bookissue_author.Text == ""
                || bookissue_issuedate.Value == null
                || bookissue_returndate.Value == null
                || issuebook_status.Text == ""
                || bookissue_picturebox.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Issue ID:"
                        + bookissue_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET date_delete = @dateDelete WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@issueID", bookissue_ID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Bookissue_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
