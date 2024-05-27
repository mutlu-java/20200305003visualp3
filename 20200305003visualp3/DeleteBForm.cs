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
    public partial class DeleteBForm : Form
    {
        private DatabaseHelper dbHelper;

        public DeleteBForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;";
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(textBox.Text);
            dbHelper.DeleteBook(bookId);
          //  MessageBox.Show("Book deleted successfully!");
            textBox.Clear();





        }
    }
}
