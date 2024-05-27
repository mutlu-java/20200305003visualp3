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
    public partial class AvailableBForm : Form
    {
        private DatabaseHelper dbHelper;
        public AvailableBForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;";
            dbHelper = new DatabaseHelper(connectionString);
            this.Load += new EventHandler(AvailableBooksForm_Load);
        }
        private void LoadBooksData()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("server=localhost;database=muhammetalimutlu;user=mutlu;password=idontknow;");
            DataTable booksTable = dbHelper.GetAllBooks();
            dataGridViewBooks.DataSource = booksTable;
        }
        private void AvailableBooksForm_Load(object sender, EventArgs e)
        {
            LoadBooksData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }

}
