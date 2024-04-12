using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
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
            Attendance AppDevLabAttendance = new Attendance();
            AppDevLabAttendance.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Attendance AppDevLecAttendance = new Attendance();
            AppDevLecAttendance.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Attendance ComProgLabAttendance = new Attendance();
            ComProgLabAttendance.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Attendance ComProgLecAttendance = new Attendance();
            ComProgLecAttendance.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Attendance OOPLabAttendance = new Attendance();
            OOPLabAttendance.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Attendance OOPLecAttendance = new Attendance();
            OOPLecAttendance.Show();
            this.Hide();
        }
    }
}
