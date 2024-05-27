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
    public partial class LendForm : Form
    {
        private DatabaseHelper dbHelper;
        public LendForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;";
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBox1.Text); // Assuming you have a TextBox `txtBookId` for entering the Book ID
            DatabaseHelper dbHelper = new DatabaseHelper("server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;");

            if (dbHelper.BorrowBook(bookId))
            {
                MessageBox.Show("Book borrowed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to borrow book. It might be out of stock.");
            }
        }
    }
}
