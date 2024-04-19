namespace Monitoring
{
    public partial class Login : Form
    {
        public class UserData
        {
            public string UserID { get; set; }
            public string Surname { get; set; }
            public bool IsStudent { get; set; }
            public string FullName { get; set; }

            public UserData(string userID, string surname, bool isStudent, string fullName)
            {
                UserID = userID;
                Surname = surname;
                IsStudent = isStudent;
                FullName = fullName;
            }
        }
        private Dictionary<string, UserData> userData = new Dictionary<string, UserData>
{
    { "202320107", new UserData("202320107", "AGAN", true, "AGAN, Michael Christian") },
    { "202312640", new UserData("202312640", "ALANGSAB", true, "ALANGSAB, Riqueta") },
    { "202311220", new UserData("202311220", "AÑASCO", true, "AÑASCO, Althea Zoe") },
    { "202313737", new UserData("202313737", "AÑONUEVO", true, "AÑONUEVO, Chrysler") },
    { "202311985", new UserData("202311985", "ATIM", true, "ATIM, Arielle Ershy") },
    { "202311009", new UserData("202311009", "BAUTISTA", true, "BAUTISTA, George Kiel") },
    { "202314266", new UserData("202314266", "BECINA", true, "BECINA, Cyrill John") },
    { "202311209", new UserData("202311209", "BIADOR", true, "BIADOR, Mark Jacob") },
    { "201811248", new UserData("201811248", "CABILAN", true, "CABILAN, Rafael") },
    { "202313091", new UserData("202313091", "CAPATI", true, "CAPATI, Kentver") },
    { "202310421", new UserData("202310421", "CASTILLO", true, "CASTILLO, Kristian Jerome") },
    { "202310879", new UserData("202310879", "CONCEPCION", true, "CONCEPCION, Lee Hendrix") },
    { "202312442", new UserData("202312442", "DE GULA", true, "DE GULA, Kerby Brent") },
    { "202311626", new UserData("202311626", "DEL PRADO", true, "DEL PRADO, Jerryco") },
    { "202313294", new UserData("202313294", "DIAZANA", true, "DIAZANA, John Darren") },
    { "202310447", new UserData("202310447", "DUMALAG", true, "DUMALAG, Jordan") },
    { "202311579", new UserData("202311579", "EDILLON", true, "EDILLON, Joshua Lloyd") },
    { "202310673", new UserData("202310673", "ESCAÑO", true, "ESCAÑO, Krisha Ann Ame") },
    { "202314222", new UserData("202314222", "ESPAÑOL", true, "ESPAÑOL, Jem Theonie") },
    { "202312225", new UserData("202312225", "GAPASIN", true, "GAPASIN, Michael Andrei") },
    { "202311127", new UserData("202311127", "GARCIA", true, "GARCIA, Enjo Mae") },
    { "202312392", new UserData("202312392", "GRICO", true, "GRICO, Cirgs Alyxander") },
    { "202312710", new UserData("202312710", "LEYESA", true, "LEYESA, Dann Martin") },
    { "202312813", new UserData("202312813", "LUZON", true, "LUZON, Adrian Dominic") },
    { "202311906", new UserData("202311906", "MADIO", true, "MADIO, Jonalyn") },
    { "202313046", new UserData("202313046", "MARTINEZ", true, "MARTINEZ, Hero") },
    { "202310536", new UserData("202310536", "MENDOZA", true, "MENDOZA, Wellhemstad") },
    { "202313050", new UserData("202313050", "MERCADO", true, "MERCADO, Nico") },
    { "202116311", new UserData("202116311", "PANAGA", true, "PANAGA, Charry") },
    { "202310292", new UserData("202310292", "PINLAC", true, "PINLAC, Kenji Luis") },
    { "202313343", new UserData("202313343", "QUIJANO", true, "QUIJANO, Tim") },
    { "202313882", new UserData("202313882", "QUILATAN", true, "QUILATAN, Marcis Joseph") },
    { "202311528", new UserData("202311528", "REYNANCIA", true, "REYNANCIA, Jessie Lei") },
    { "202119459", new UserData("202119459", "RODRIGUEZ", true, "RODRIGUEZ, Rhegille Gabriel") },
    { "202313427", new UserData("202313427", "SAMACO", true, "SAMACO, Cyrus") },
    { "202311959", new UserData("202311959", "SILANG", true, "SILANG, Le Bron James") },
    { "202311615", new UserData("202311615", "SIMON", true, "SIMON, Kielle Francez") },
    { "202310850", new UserData("202310850", "SOLO", true, "SOLO, John") },
    { "202313020", new UserData("202313020", "STA. ANA", true, "STA. ANA, Mary Angelique") },
    { "202313899", new UserData("202313899", "TAGLE", true, "TAGLE, Jel Kyann") },
    { "202310728", new UserData("202310728", "VARELA", true, "VARELA, Venice Ariane") },
    { "202312834", new UserData("202312834", "YABUT", true, "YABUT, Aleerah Marishka") },
    { "202312647", new UserData("202312647", "ZAPATA", true, "ZAPATA, Kurt Anthony") },
    { "1", new UserData("1", "ALVEZ", false, "ALVEZ, Jerome") }
};



        public Login()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = usernameTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            if (userData.ContainsKey(inputUsername) && userData[inputUsername].Surname == inputPassword)
            {
                UserData loggedInUser = userData[inputUsername];

                if (loggedInUser.IsStudent)
                {
                    Courses studentForm = new Courses(loggedInUser);
                    studentForm.Show();
                    this.Hide();
                }
                else
                {
                    Courses courseForm = new Courses(loggedInUser);
                    courseForm.Show();
                    this.Hide();
                }
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