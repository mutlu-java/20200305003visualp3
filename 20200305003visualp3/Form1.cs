namespace _20200305003visualp3
{
    public partial class Window : Form
    {
        private const string USERNAME = "username";
        private const string PASSWORD = "password";
        private DatabaseHelper dbHelper;
        public Window()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=library;" +
                "user=officer;password=libpassword;";
            dbHelper = new DatabaseHelper(connectionString);

        }

        private void sýgnButton_Click(object sender, EventArgs e)
        {
            string username=usernametextBox.Text;
            string password= passwordtextBox.Text;

            if (username == USERNAME && password ==PASSWORD) {


                OptionForm optionForm = new OptionForm();
                optionForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
