using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring
{
    public class Student
    {
        public string Name { get; set; }
        public string StudentID { get; set; }
        public AttendanceRecord[] AttendanceRecords { get; set; }
    }

    public class AttendanceRecord
    {
        public DateTime Date { get; set; }
        public int Status { get; set; } // Use integer to represent status
        public string Subject { get; set; }
    }
}
