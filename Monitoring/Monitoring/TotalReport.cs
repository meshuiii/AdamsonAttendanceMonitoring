using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Monitoring
{
    public partial class TotalReport : Form
    {
        public DateTime SelectedDate;
        public int SelectedSubject;
        public Attendance.Status Status;
        public List<Attendance.Status> StatusList;
        public string[] StudentName;
        public string[] StudentNo;
        public TotalReport(string[] studentName, string[] studentNo, List<Attendance.Status> statusList)
        {
            InitializeComponent();
            StudentName = studentName;
            StudentNo = studentNo;
            SelectedDate = DateTime.Now;
            StatusList = statusList;
            InitializeStudentData(studentName, studentNo);

        }


        private void InitializeStudentData(string[] studentNames, string[] studentIDs)
        {
            for (int i = 0; i < studentNames.Length; i++)
            {
                StudentData.StudentsList.Add(new Student
                {
                    Name = studentNames[i],
                    ID = studentIDs[i],
                    TotalDaysPresent = 0 // Initialize total days present to 0
                });
            }
        }
        public void DisplayTotalReport()
        {
            flowLayoutPanel1.Controls.Clear();

            // Filter attendance records for the selected date and subject
            var matchingStatuses = StatusList.Where(status => status.Subject == SelectedSubject);

            foreach (var student in StudentData.StudentsList)
            {
                // Reset total days present for each student
                student.TotalDaysPresent = 0;

                // Calculate total days present for each student
                int late = 0;
                foreach (var status in matchingStatuses)
                {
                    switch (status.AttendanceStatus[StudentData.StudentsList.IndexOf(student)])
                    {
                        case 4: // Present
                            student.TotalDaysPresent++;
                            break;
                        case 2: // Late
                            student.TotalDaysPresent++;
                            late++;
                            if (late % 3 == 0)
                            {
                                student.TotalDaysPresent--;
                                late = 0;
                            }
                            break;
                        case 1: // Excused
                            student.TotalDaysPresent++;
                            break;
                        default: // Absent or No input
                            break;
                    }
                }

                // Populate groupboxes
                GroupBox groupBox = new GroupBox();
                groupBox.Text = student.Name;

                Label id = new Label();
                id.Text = student.ID;
                id.Location = new System.Drawing.Point(250, 0);

                Label totalAttendance = new Label();
                totalAttendance.Text = $"{student.TotalDaysPresent} / {matchingStatuses.Count()} = {((float)student.TotalDaysPresent / matchingStatuses.Count()) * 100}%";
                totalAttendance.Location = new System.Drawing.Point(375, 0);

                groupBox.Controls.Add(id);
                groupBox.Controls.Add(totalAttendance);
                groupBox.Size = new System.Drawing.Size(470, 25);

                flowLayoutPanel1.Controls.Add(groupBox);
            }

            if (!matchingStatuses.Any())
            {
                MessageBox.Show("No attendance records found for the selected date/subject.");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSubject = comboBox1.SelectedIndex;
            DisplayTotalReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Hide();
        }

        private void TotalReport_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
