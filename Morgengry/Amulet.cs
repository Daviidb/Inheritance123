using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low,
        medium,
        high
    }
    public class Amulet : Merchandise
    {

        Level quality;
        string design = "";



        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }
        public string Design
        {
            get { return design; }
            set { design = value; }
        }

        public  double LowQualityValue { get; set; }
        public  double MediumQualityValue { get; set; }
        public  double HighQualityValue { get; set; }



        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public Amulet(string itemId, Level quality) : this(itemId, quality, "") { }

        public Amulet(string itemId) : this(itemId, Level.medium) { }

        
        public override string ToString()
        {
            string result = null;

            result += "ItemId: " + ItemId + ", ";
            result += "Quality: " + quality + ", ";
            result += "Design: " + design;

            return result;
        }

        public override double GetValue()
        {
            double value = 0;
            if (Quality == Level.low)
            {
                value = 12.5;
            }

            else if (Quality == Level.medium)
            {
                value = 20.0;
            }

            else
            {
                value = 27.5;
            }
            return value;
        }
    }
}
