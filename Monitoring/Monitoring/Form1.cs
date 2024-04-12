namespace Monitoring
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            {"admin1", "password1"},
            {"admin2", "password2"},
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

            if (users.ContainsKey(inputUsername) && users[inputUsername] == inputPassword)
            {
                
                MessageBox.Show("Login successful!");

                if (inputUsername.StartsWith("admin"))
                {
                    Courses courseForm = new Courses();
                    courseForm.Show();
                }


                else if (inputUsername.StartsWith("student"))
                {
                    Courses studentForm = new Courses();
                    studentForm.Show();
                }
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