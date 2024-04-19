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
        public string ID { get; set; }
        public int TotalDaysPresent { get; set; }
    }

    public static class StudentData
    {
        public static List<Student> StudentsList { get; set; } = new List<Student>();
    }
}
