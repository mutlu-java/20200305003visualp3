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
    public partial class UpdateForm : Form
    {
        private DatabaseHelper dbHelper;
        public UpdateForm()  
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;";
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(bookidtextBox1.Text);
            string title = titletextBox2.Text;
            string author = authortextBox3.Text;
            string isbn = isbntextBox4.Text;
            int yearPublished = Convert.ToInt32(yearspublishedtextBox5.Text);
            string genre = genretextBox6.Text;
            int copiesAvailable = Convert.ToInt32(copiesavailabletextBox7.Text);

            dbHelper.UpdateBook(bookId, title, author, isbn, yearPublished, genre, copiesAvailable);
        }
    }
}
