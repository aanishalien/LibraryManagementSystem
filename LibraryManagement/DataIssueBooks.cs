using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement
{
   
    class DataIssueBooks
    {
        SqlConnection conn =
        new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gadget Fix\source\repos\LibraryManagement\LibraryManagement\librarymanagement.mdf;Integrated Security=True;Connect Timeout=30");
        public string ID { set; get; }

        public string IssueID { set; get; }

        public string Name { set; get; }

        public string Contact { set; get; }

        public string Email { set; get; }
        public string BookTitle { set; get; }

        public string  Author { set; get;}
        
        
        public string DateIssue { set; get; }
        public string DataReturn { set; get; }

        public string Status { set; get; }

        public List<DataIssueBooks>IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();         
              if(conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        string selectData = "SELECT * FROM issues WHERE date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, conn))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();

                            if(reader.Read())
                            {
                                DataIssueBooks dib = new DataIssueBooks();
                                dib.ID = reader["id"].ToString(); // Convert to string
                                dib.IssueID = reader["issue_id"].ToString();
                                dib.Name = reader["full_name"].ToString();
                                dib.Contact = reader["contact"].ToString();
                                dib.Email = reader["email"].ToString();
                                dib.BookTitle = reader["book_title"].ToString();
                                dib.Author = reader["author"].ToString();                          
                                dib.DateIssue = reader["issue_date"].ToString();
                                dib.DataReturn = reader["return_date"].ToString();
                                dib.Status = reader["status"].ToString();

                                listData.Add(dib);


                            }
                            reader.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error: " + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                return listData;
        }

        public List<DataIssueBooks> ReturnIssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM issues WHERE status = 'Not Return' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.ID = reader["id"].ToString(); // Convert to string
                            dib.IssueID = reader["issue_id"].ToString();
                            dib.Name = reader["full_name"].ToString();
                            dib.Contact = reader["contact"].ToString();
                            dib.Email = reader["email"].ToString();
                            dib.BookTitle = reader["book_title"].ToString();
                            dib.Author = reader["author"].ToString();
                            dib.DateIssue = reader["issue_date"].ToString();
                            dib.DataReturn = reader["return_date"].ToString();
                            dib.Status = reader["status"].ToString();

                            listData.Add(dib);


                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            return listData;
        }
    }
}
