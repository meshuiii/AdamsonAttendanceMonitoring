using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Attendance;

namespace Monitoring
{
    public partial class ClassReport : Form
    {
        public ClassReport()
        {
            InitializeComponent();
            SelectedDate = DateTime.Now;
        }

        public DateTime SelectedDate = new DateTime();
        public string[] StudentName;
        public string[] StudentNo;
        public Status Status;
        public void GetData(string[] studentName, string[] studentNo, Status status)
        {
            StudentName = studentName;
            StudentNo = studentNo;
            Status = status;
        }

        public void DisplayAttendance(string[] studentName, string[] studentNo, Status status)
        {
            //if (Status.DateTimeStamp.Date == SelectedDate.Date)
            //{
            for (int i = 0; i < studentName.Length; i++)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = studentName[i];

                Label id = new Label();
                id.Text = studentNo[i];
                id.Location = new System.Drawing.Point(150, 0);

                Label present = new Label();
                present.Text = status.AttendanceStatus[i].ToString();
                //present.Text = "Test";
                present.Location = new System.Drawing.Point(345, 0);

                groupBox.Controls.Add(id);
                groupBox.Controls.Add(present);
                groupBox.Size = new System.Drawing.Size(500, 40); // Width = 200, Height = 150

                flowLayoutPanel1.Controls.Add(groupBox);
                groupBox.TabIndex = i;
            }
            //}
            //else
            //{
            //    MessageBox.Show("Data not found");
            //}
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = dateTimePicker1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAttendance(StudentName, StudentNo, Status);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
