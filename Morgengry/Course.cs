using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{

    public class Course
    {
        string name = "";
        int durationInMinutes = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public Course(string name) : this(name, 0) {}

        public Course () {}

        public override string ToString()
        {
            string result = null;

            result += "Name: " + Name + ", ";
            result += "Duration in Minutes: " + DurationInMinutes;

            return result;
        }
    }
}
