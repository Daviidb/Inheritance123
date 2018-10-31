using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfBook (Book book)
        {
            return book.getPrice();
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.getQuality() == Amulet.Level.low) {
                return 12.5;
            }

            else if (amulet.getQuality() == Amulet.Level.medium)
            {
                return 20.0;
            }

            else
            {
                return 27.5;
            }
        }

        public static double GetValueOfCourse(Course course)
        {
            double initialPrice = 875;
            double coursePrice = 0.0;
            for (int i = 0; i < course.DurationInMinutes / 60; i++)
            {
                coursePrice += 875;
            }

            if (course.DurationInMinutes == 0)
            {
                return 0;
            }
             else
            {
                return coursePrice + initialPrice;
            }

        }
    }
}
