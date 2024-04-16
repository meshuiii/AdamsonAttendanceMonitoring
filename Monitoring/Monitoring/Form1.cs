namespace Monitoring
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> adminUsers = new Dictionary<string, string>
        {
            {"admin1", "password1"}
        };

        private Dictionary<string, string> studentUsers = new Dictionary<string, string>
        {

            {"student1", "student1"},
            {"student2", "student2"},
            {"student3", "student3"}
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = usernameTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            if (adminUsers.ContainsKey(inputUsername) && adminUsers[inputUsername] == inputPassword)
            {
                MessageBox.Show("Login successful as Admin!");
                Courses courseForm = new Courses();
                courseForm.Show();
                this.Hide();
            }
            else if (studentUsers.ContainsKey(inputUsername) && studentUsers[inputUsername] == inputPassword)
            {
                MessageBox.Show("Login successful as Student!");
                Courses studentForm = new Courses();
                studentForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}