﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitoring.Login;

namespace Monitoring
{
    public partial class StudentViewAttendance : Form
    {
        private UserData loggedInUser;
        private int absentCount = 0;
        private int lateCount = 0;
        private int presentCount = 0;
        private int excusedCount = 0;


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
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e)
        {
            List<StudentAttendance> attendanceRecords = Student.AttendanceRecords;
            AllocConsole();
            string selectedSubject = comboBox1.SelectedItem.ToString();

            // Find the attendance record of the logged-in student
            List<StudentAttendance> studentRecordsForSubject = attendanceRecords.Where(record =>
        record.StudentName == loggedInUser.FullName && record.Subject == selectedSubject).ToList();

            if (studentRecordsForSubject.Any())
            {
                Console.WriteLine($"Attendance Record for: {loggedInUser.FullName}, Subject: {selectedSubject}");
                foreach (var studentRecord in studentRecordsForSubject)
                {
                    Console.WriteLine("Date: " + studentRecord.Date);
                    Console.WriteLine("Attendance Status: " + GetAttendanceStatus(studentRecord.AttendanceStatus));

                    // Update counters based on attendance status
                    UpdateCounters(studentRecord.AttendanceStatus);
                }
            }
            else
            {
                Console.WriteLine($"Attendance record not found for: {loggedInUser.FullName}, Subject: {selectedSubject}");
            }
        }

        private void UpdateCounters(int status)
        {
            switch (status)
            {
                case 4:
                    presentCount++;
                    break;
                case 3:
                    absentCount++;
                    break;
                case 2:
                    lateCount++;
                    if (lateCount % 3 == 0)
                    {
                        absentCount++;
                        lateCount = 0;
                    }
                    break;
                case 1:
                    excusedCount++;
                    break;
            }

            Console.WriteLine($"Absent Count: {absentCount}");
            Console.WriteLine($"Late Count: {lateCount}");
            Console.WriteLine($"Present Count: {presentCount}");
            Console.WriteLine($"Excused Count: {excusedCount}");
        }

        private string GetAttendanceStatus(int status)
        {
            switch (status)
            {
                case 4:
                    return "Present";
                case 3:
                    return "Absent";
                case 2:
                    return "Late";
                case 1:
                    return "Excused";
                default:
                    return "No input";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            // Get the selected subject from the ComboBox
            string selectedSubject = comboBox1.SelectedItem.ToString();

            // Filter attendance records for the selected subject and logged-in user
            List<StudentAttendance> attendanceRecords = Student.AttendanceRecords;
            List<StudentAttendance> studentRecordsForSubject = attendanceRecords
                .Where(record => record.StudentName == loggedInUser.FullName && record.Subject == selectedSubject)
                .ToList();

            // Group attendance records by date
            var groupedRecords = studentRecordsForSubject.GroupBy(record => record.Date);

            if (groupedRecords.Any())
            {
                foreach (var group in groupedRecords)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = $"Date: {group.Key}";

                    foreach (var studentRecord in group)
                    {
                        Label attendanceStatus = new Label();
                        attendanceStatus.Text = $"Status: {GetAttendanceStatus(studentRecord.AttendanceStatus)}";
                        attendanceStatus.Location = new System.Drawing.Point(10, 20 + groupBox.Controls.Count * 30);

                        groupBox.Controls.Add(attendanceStatus);
                    }

                    groupBox.Size = new System.Drawing.Size(470, 50 + group.Count() * 30);

                    flowLayoutPanel1.Controls.Add(groupBox);
                }
            }
            else
            {
                MessageBox.Show($"No attendance records found for the selected subject: {selectedSubject}.");
            }
        }
    }
}
