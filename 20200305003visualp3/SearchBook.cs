using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200305003visualp3
{
    public partial class SearchBook : Form
    {
        private DatabaseHelper dbHelper;
        public SearchBook()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;";
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTitle = textBox1.Text; 
            DatabaseHelper dbHelper = new DatabaseHelper("server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;");

            try
            {
                DataTable booksTable = dbHelper.SearchBooksByTitle(searchTitle);
                dataGridViewBooks.DataSource = booksTable;
                if (booksTable.Rows.Count == 0)
                {
                    MessageBox.Show("No books found with the given title.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search books. Error: " + ex.Message);
            }
        }
    }
}
