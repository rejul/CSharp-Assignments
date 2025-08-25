using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    public class Course 
    {
        //The 
        // Course class includes title and duration (single subject)
        private string _title;
        private string _duration;

        
        public string Title 
        { 
            get { return _title; } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                _title = value; 
            }
        }

        public string Duration 
        { 
            get { return _duration; } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Duration cannot be empty.");
                }
                _duration = value; 
            }
        }

        public Course(string title,string duration)
        {
            this.Title = title;
            this.Duration = duration;
        }
 

    }
}
