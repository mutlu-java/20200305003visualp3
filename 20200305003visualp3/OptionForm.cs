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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteBForm deleteBForm = new DeleteBForm();
            deleteBForm.Show();
        }

        private void addBookbutton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();

        }

        private void updateBookbutton_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void displayBooksbutton_Click(object sender, EventArgs e)
        {
            AvailableBForm availableBForm = new AvailableBForm();
                availableBForm.Show();
        }

        private void searchBookButton_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LendForm lendForm = new LendForm();
               lendForm.Show();
        }
    }
}
