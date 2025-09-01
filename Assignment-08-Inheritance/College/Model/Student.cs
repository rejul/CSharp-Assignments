using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    public class Student:Course
    {
        //Student has the attributes Name, Student ID and Major.
        public string? Name { get; set; }
        public int? StudentID { get; set; }
        public string? Major { get; set; }
        public Student()
        {
            Name = null;
            StudentID = null;
            Major = null;
        }

        //study fn

        public Student(int studentID, string name, string major, string title, string duration) : base(title, duration)
        {
            this.StudentID = studentID;
            this.Name = name;
            this.Major = major;
        }

      s

    }
}
