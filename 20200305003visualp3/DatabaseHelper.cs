using MySql.Data.MySqlClient;  // Ensure this is included at the top, instead of using System.Data.SqlClient
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20200305003visualp3
{
    public class DatabaseHelper
    {
        // private string connectionString;
        string connectionString = "server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;";


        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /*  public void AddBook(string title, string author, string isbn, int yearPublished, string genre, int copiesAvailable)
          {
              using (var conn = new MySqlConnection(connectionString))
              {
                  var cmd = new MySqlCommand("INSERT INTO Books (Title, Author, ISBN, YearPublished, Genre, CopiesAvailable) VALUES (@Title, @Author, @ISBN, @YearPublished, @Genre, @CopiesAvailable)", conn);
                  cmd.Parameters.AddWithValue("@Title", title);
                  cmd.Parameters.AddWithValue("@Author", author);
                  cmd.Parameters.AddWithValue("@ISBN", isbn);
                  cmd.Parameters.AddWithValue("@YearPublished", yearPublished);
                  cmd.Parameters.AddWithValue("@Genre", genre);
                  cmd.Parameters.AddWithValue("@CopiesAvailable", copiesAvailable);
                  conn.Open();
                  cmd.ExecuteNonQuery();
              }
          }*/

        /*  public void AddBook(string title, string author, string isbn, int yearPublished, string genre, int copiesAvailable)
          {
              try
              {
                  using (var conn = new MySqlConnection(connectionString))
                  {
                      var cmd = new MySqlCommand("INSERT INTO books (Title, Author, ISBN, YearPublished, Genre, CopiesAvailable) VALUES (@Title, @Author, @ISBN, @YearPublished, @Genre, @CopiesAvailable)", conn);
                      cmd.Parameters.AddWithValue("@Title", title);
                      cmd.Parameters.AddWithValue("@Author", author);
                      cmd.Parameters.AddWithValue("@ISBN", isbn);
                      cmd.Parameters.AddWithValue("@YearPublished", yearPublished);
                      cmd.Parameters.AddWithValue("@Genre", genre);
                      cmd.Parameters.AddWithValue("@CopiesAvailable", copiesAvailable);
                      conn.Open();
                      cmd.ExecuteNonQuery();
                  }
              }
              catch (MySqlException ex)
              {
                  // Handle specific MySQL errors here
                  Console.WriteLine("MySQL Error: " + ex.Message);
              }
              catch (Exception ex)
              {
                  // Handle other errors
                  Console.WriteLine("Error: " + ex.Message);
              }
          }*/

        public void AddBook(int bookId, string title, string author, string isbn, int yearPublished, string genre, int copiesAvailable)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("INSERT INTO Books (BookID, Title, Author, ISBN, YearPublished, Genre, CopiesAvailable) VALUES (@BookID, @Title, @Author, @ISBN, @YearPublished, @Genre, @CopiesAvailable)", conn);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@YearPublished", yearPublished);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@CopiesAvailable", copiesAvailable);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateBook(int bookId, string title, string author, string isbn, int yearPublished, string genre, int copiesAvailable)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("UPDATE Books SET Title=@Title, Author=@Author, ISBN=@ISBN, YearPublished=@YearPublished, Genre=@Genre, CopiesAvailable=@CopiesAvailable WHERE BookID=@BookID", conn);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@YearPublished", yearPublished);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@CopiesAvailable", copiesAvailable);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Book updated successfully!");
                }
                else
                {
                    Console.WriteLine("No book found with the specified ID.");
                }
            }
        }
        public void DeleteBook(int bookId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("DELETE FROM Books WHERE BookID=@BookID", conn);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Book deleted successfully!");
                    MessageBox.Show("Book deleted successfully!");
                }
                else
                {
                    Console.WriteLine("No book found with the specified ID, or the book cannot be deleted.");
                    MessageBox.Show("No book found with the specified ID, or the book cannot be deleted");
                }
            }
        }

        public bool BorrowBook(int bookId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Start a transaction
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Check available copies
                        string checkQuery = "SELECT CopiesAvailable FROM books WHERE BookID = @BookID AND CopiesAvailable > 0";
                        using (var checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@BookID", bookId);
                            int copiesAvailable = Convert.ToInt32(checkCmd.ExecuteScalar() ?? 0);

                            if (copiesAvailable > 0)
                            {
                                // Update the CopiesAvailable
                                string updateQuery = "UPDATE books SET CopiesAvailable = CopiesAvailable - 1 WHERE BookID = @BookID";
                                using (var updateCmd = new MySqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@BookID", bookId);
                                    updateCmd.ExecuteNonQuery();
                                    transaction.Commit();
                                    return true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No copies available to borrow.");
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public DataTable SearchBooksByTitle(string title)
        {
            DataTable dataTable = new DataTable();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Using a parameterized query to avoid SQL injection
                string query = "SELECT BookID, Title, Author, ISBN, YearPublished, Genre, CopiesAvailable FROM books WHERE Title LIKE CONCAT('%', @Title, '%')";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", title);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        /*    public DataTable GetAvailableBooks()
            {
                DataTable dataTable = new DataTable();

                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT BookID, Title, Author, ISBN, YearPublished, Genre, CopiesAvailable FROM books WHERE CopiesAvailable > 0";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Optionally handle the error more gracefully, log it, or display it to the user
                    }
                }

                return dataTable;
            }
        */

        public DataTable GetAllBooks()
        {
            DataTable dataTable = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT BookID, Title, Author, ISBN, YearPublished, Genre, CopiesAvailable FROM books";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

    }
}

