using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{

    public class Course : IValuable
    {
        string name = "";
        int durationInMinutes = 0;
        double courseHourValue = 825;



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

        public double CourseHourValue {
            get { return courseHourValue; }
            set { courseHourValue = value; }
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
            result += "Duration in Minutes: " + DurationInMinutes + ", ";
            result += "Pris pr påbegyndt time: " + CourseHourValue;

            return result;
        }

        public double GetValue()
        {
            double initialPrice = CourseHourValue;
            double result = 0.0;

            if (DurationInMinutes != 0)
            {
                result = ((DurationInMinutes / 60) + 1) * initialPrice;
            }
            return result;
        }
    }
}
