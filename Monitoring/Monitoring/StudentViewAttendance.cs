using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Login;

namespace Monitoring
{
    public partial class StudentViewAttendance : Form
    {
        private UserData loggedInUser;

        public StudentViewAttendance(UserData userData)
        {
            InitializeComponent();
            this.loggedInUser = userData;
            label7.Text = loggedInUser.FullName;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser);
            AttendanceStudent.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            StudentViewAttendance AttendanceStudent = new StudentViewAttendance(loggedInUser);
            AttendanceStudent.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentViewAttendance_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Courses courseForm = new Courses(loggedInUser);
            courseForm.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Courses courseForm = new Courses(loggedInUser);
            courseForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser);
            StudentMission.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mission StudentMission = new Mission(loggedInUser);
            StudentMission.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser);
            StudentVision.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Vision StudentVision = new Vision(loggedInUser);
            StudentVision.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Close();
        }
    }
}
