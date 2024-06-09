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
using System.IO;

namespace LibraryManagement
{
    public partial class AddBook : UserControl
    {
        SqlConnection conn =
          new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gadget Fix\source\repos\LibraryManagement\LibraryManagement\librarymanagement.mdf;Integrated Security=True;Connect Timeout=30");
        public AddBook()
        {
            InitializeComponent();

            displayBooks();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBooks();
        }

        private void Addbook_importbtn_Click(object sender, EventArgs e)
        {
            String imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images Files(*.jpg; *.png)| *.jpg; *.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addbooks_picture.ImageLocation = imagePath;

                }

            } catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            {
                if (addbooks_picture.Image == null
                    || addbooks_author.Text == ""
                    || addbooks_author.Text == ""
                    || addbooks_published.Value == null
                    || addbooks_status.Text == ""
                    || addbooks_picture.Image== null)
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            conn.Open();
                            string insertData = "INSERT INTO books" +
                                "(book_title,author,published_date,status,image,date_insert)" +
                                "VALUES(@bookTitle,@author,@published_date,@status,@image,@dateInsert)";

                            string path = Path.Combine(@"C:\Users\Gadget Fix\source\repos\LibraryManagement\LibraryManagement\Books_Directory\" +
                           addbooks_booktitle.Text.Trim() +addbooks_author.Text.Trim() + "_" + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }
                            File.Copy(addbooks_picture.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, conn))
                            {
                                cmd.Parameters.AddWithValue("@bookTitle", addbooks_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addbooks_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@published_date", addbooks_published.Value);
                                cmd.Parameters.AddWithValue("@status", addbooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", path);
                                cmd.Parameters.AddWithValue("@dateinsert", today);

                                cmd.ExecuteNonQuery();
                                
                               

                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayBooks();
                                clearFields();


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
        }
        public void clearFields()
        {
            addbooks_booktitle.Text = "";
            addbooks_author.Text = "";
            addbooks_picture.Image = null;
            addbooks_status.SelectedIndex = -1;

        }
        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;
        }
        private void Addbooks_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int bookID = 0;

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookID = (int)row.Cells[0].Value;
                addbooks_booktitle.Text = row.Cells[1].Value.ToString();
                addbooks_author.Text = row.Cells[2].Value.ToString();
                addbooks_published.Value = Convert.ToDateTime(row.Cells[3].Value);

                string imagePath = row.Cells[4].Value.ToString();

                if(imagePath != null ||imagePath.Length >=1)
                {
                    addbooks_picture.Image = Image.FromFile(row.Cells[4].Value.ToString());
                }
                else
                {
                    addbooks_picture.Image = null;
                }
                addbooks_status.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if(addbooks_picture.Image == null
                || addbooks_booktitle.Text == ""
                || addbooks_author.Text == ""
                || addbooks_published.Value == null
                || addbooks_status.Text == ""
                || addbooks_picture.Image ==  null)
            {
                MessageBox.Show("Please select item first", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(conn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE  books SET book_title = @bookTitle" +
                    ",author = @author,published_date = @published" +
                    ",status = @status,date_update= @dateUpdate WHERE id = @id";


                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {
                                cmd.Parameters.AddWithValue("@bookTitle", addbooks_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addbooks_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", addbooks_published.Value);
                                cmd.Parameters.AddWithValue("@status", addbooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);

                                cmd.Parameters.AddWithValue("@id", bookID);


                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          
                                clearFields();

                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Addbooks_deletebtn_Click(object sender, EventArgs e)
        {
            if (addbooks_picture.Image == null
                || addbooks_booktitle.Text == ""
                || addbooks_author.Text == ""
                || addbooks_published.Value == null
                || addbooks_status.Text == ""
                || addbooks_picture.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string deleteData = "UPDATE  books SET date_delete=@dateDelete WHERE id = @id";


                            using (SqlCommand cmd = new SqlCommand(deleteData, conn))
                            {
                                
                                cmd.Parameters.AddWithValue("@dateDelete", today);

                                cmd.Parameters.AddWithValue("@id", bookID);


                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
