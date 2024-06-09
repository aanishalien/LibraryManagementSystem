using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class DataAddBooks
    {
        SqlConnection conn 
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gadget Fix\source\repos\LibraryManagement\LibraryManagement\librarymanagement.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }

        public string BookTitle { set; get; }

        public string Author { set; get; }
        public string Published { set; get; }
        public string image { set; get; }
        public string Status { set; get; }

        public List<DataAddBooks> addBooksData()
        {
            List<DataAddBooks> listData = new List<DataAddBooks>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM books WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                       

                        while(reader.Read())
                        {
                            DataAddBooks dab = new DataAddBooks();
                            dab.ID = (int)reader["id"];
                            dab.BookTitle = reader["book_title"].ToString();
                            dab.Author = reader["author"].ToString();
                            dab.Published = reader["published_date"].ToString();
                            dab.image = reader["image"].ToString();
                            dab.Status = reader["status"].ToString();

                            listData.Add(dab);
                        }
                        reader.Close();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Connecting Database:" + ex);
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
