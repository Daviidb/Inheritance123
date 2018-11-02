using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfMerchandise(Merchandise merchandise)
        {

            double value = 0;
            if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;
                if (amulet.Quality == Level.low)
                {
                    value = 12.5;
                }

                else if (amulet.Quality == Level.medium)
                {
                    value = 20.0;
                }

                else
                {
                    value = 27.5;
                }
            }

            else if (merchandise is Book)
            {
                Book book = (Book)merchandise;
                value = book.getPrice();
            }
            else
            {
                value = 0;
            }

            return value;
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
