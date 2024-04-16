using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Form1;

namespace Monitoring
{
    public partial class Courses : Form
    {
        private UserData loggedInUser;

        public Courses(UserData userData)
        {
            InitializeComponent();
            this.loggedInUser = userData;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {

                StudentViewAttendance AppDevLabAttendanceStudent = new StudentViewAttendance(loggedInUser);
                AppDevLabAttendanceStudent.Show();
                this.Hide();
            }
            else
            {

                Attendance AppDevLabAttendance = new Attendance(loggedInUser);
                AppDevLabAttendance.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {

                StudentViewAttendance AppDevLecAttendanceStudent = new StudentViewAttendance(loggedInUser);
                AppDevLecAttendanceStudent.Show();
                this.Hide();
            }
            else
            {

                Attendance AppDevLecAttendance = new Attendance(loggedInUser);
                AppDevLecAttendance.Show();
                this.Hide();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {

                StudentViewAttendance ComProgLabAttendanceStudent = new StudentViewAttendance(loggedInUser);
                ComProgLabAttendanceStudent.Show();
                this.Hide();
            }
            else
            {

                Attendance ComProgLabAttendance = new Attendance(loggedInUser);
                ComProgLabAttendance.Show();
                this.Hide();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {

                StudentViewAttendance ComProgLecAttendanceStudent = new StudentViewAttendance(loggedInUser);
                ComProgLecAttendanceStudent.Show();
                this.Hide();
            }
            else
            {

                Attendance ComProgLecAttendance = new Attendance(loggedInUser);
                ComProgLecAttendance.Show();
                this.Hide();
            }
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {

                StudentViewAttendance OOPLabAttendanceStudent = new StudentViewAttendance(loggedInUser);
                OOPLabAttendanceStudent.Show();
                this.Hide();
            }
            else
            {

                Attendance OOPLabAttendance = new Attendance(loggedInUser);
                OOPLabAttendance.Show();
                this.Hide();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (loggedInUser.IsStudent)
            {

                StudentViewAttendance OOPLecAttendanceStudent = new StudentViewAttendance(loggedInUser);
                OOPLecAttendanceStudent.Show();
                this.Hide();
            }
            else
            {

                Attendance OOPLecAttendance = new Attendance(loggedInUser);
                OOPLecAttendance.Show();
                this.Hide();
            }

        }

        private void Courses_Load(object sender, EventArgs e)
        {

        }
    }
}
