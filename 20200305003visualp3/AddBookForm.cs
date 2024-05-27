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
    public partial class AddBookForm : Form
    {
        private DatabaseHelper dbHelper;

        public AddBookForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;";
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddBookbutton_Click(object sender, EventArgs e)
        {
            // Collect data from textboxes
            int bookId = int.Parse(bookidtextBox.Text);
            string title = titletextBox.Text;
            string author = authortextBox.Text;
            string isbn = isbntextBox.Text;
            int yearPublished = int.Parse(yearpublishedtextBox.Text); // Ensure that input is validated or convert safely
            string genre = genretextBox.Text;
            int copiesAvailable = int.Parse(copiesavailabletextBox.Text); // Ensure that input is validated or convert safely

            // Call AddBook method to add the book to the database
            dbHelper.AddBook(bookId, title, author, isbn, yearPublished, genre, copiesAvailable);

            // Optionally clear the textboxes or give feedback
            MessageBox.Show("Book added successfully!");
            titletextBox.Clear();
            authortextBox.Clear();
            isbntextBox.Clear();
            yearpublishedtextBox.Clear();
            genretextBox.Clear();
            copiesavailabletextBox.Clear();
            bookidtextBox.Clear();

        }
    }
}
