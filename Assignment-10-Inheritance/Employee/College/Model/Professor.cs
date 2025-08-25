using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    public class Professor : Course
    {
        //Design Professor class with attributes Name, EmpID and Major
        public string? Name { get; set; }
        public int? EmpID { get; set; }
        public string? Major { get; set; }

        public Professor()
        {
            Name = null;
            EmpID = null;
            Major = null;
        }

        public Professor(int empID, string name, string major, string title, string duration):base(title, duration)
        {
            this.EmpID = empID;
            this.Name = name;
            this.Major = major;

        }

        //teach fn
        public void Teach(int _empID, string _name, string _major)
        {
            this.EmpID = _empID;
            this.Name = _name;
            this.Major = _major;
        }

        public override string ToString()
        {
            return
                $"Professor Name: {Name}, EmpID: {EmpID}, Major: {Major}, Course Title: {Title}, Course Duration: {Duration}";

        }
    }
}
