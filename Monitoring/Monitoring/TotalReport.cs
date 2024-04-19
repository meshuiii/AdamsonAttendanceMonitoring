
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

        }

        public void DisplayTotalReport()
        {
            flowLayoutPanel1.Controls.Clear();

            // Filter attendance records for the selected date and subject
            var matchingStatuses = StatusList.Where(status => status.Subject == SelectedSubject);

            int[] presentDays = new int[StudentName.Length];
            for (int i = 0; i < StudentName.Length; i++)
            {
                // Calculate attendance percentage, present/absent
                int late = 0;
                foreach (var status in matchingStatuses)
                {
                    switch (status.AttendanceStatus[i])
                    {
                        case 4: // Present
                            presentDays[i]++; break;
                        case 3: break; // Absent
                        case 2: // Late
                            presentDays[i]++; late++;
                            if (late % 3 == 0)
                            {
                                presentDays[i]--;
                                late = 0;
                            }
                            break;
                        case 1: // Excused
                            presentDays[i]++; break;
                        default: break; // No input
                    }
                }

                // Populate groupboxes
                GroupBox groupBox = new GroupBox();
                groupBox.Text = StudentName[i];

                Label id = new Label();
                id.Text = StudentNo[i];
                id.Location = new System.Drawing.Point(250, 0);

                Label totalAttendance = new Label();
                totalAttendance.Text = $"{presentDays[i]} / {matchingStatuses.Count()} = {((float)presentDays[i] / matchingStatuses.Count()) * 100}%";
                totalAttendance.Location = new System.Drawing.Point(375, 0);

                groupBox.Controls.Add(id);
                groupBox.Controls.Add(totalAttendance);
                groupBox.Size = new System.Drawing.Size(470, 25);

                flowLayoutPanel1.Controls.Add(groupBox);
                groupBox.TabIndex = i;
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