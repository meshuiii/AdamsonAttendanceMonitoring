using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring
{
    public class StudentAttendance
    {
        public string StudentName { get; set; }
        public DateTime Date { get; set; }
        public int AttendanceStatus { get; set; }
        public string Subject { get; set; }
    }

    public static class Student
    {
        private static List<StudentAttendance> attendanceRecords = new List<StudentAttendance>();

        public static List<StudentAttendance> AttendanceRecords
        {
            get { return attendanceRecords; }
            set { attendanceRecords = value; }
        }
    }
}
