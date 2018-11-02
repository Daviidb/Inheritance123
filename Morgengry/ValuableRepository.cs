using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository : IValuable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable (IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable (string id)
        {
            for (int i = 0; i < valuables.Count; i++)
            {
                if (valuables[i] is Course)
                { 

                }
            }
        }

        public double  GetTotalValue ()
        {
            return 0;
        }

        public int Count ()
        {
            return valuables.Count;
        }


        public double GetValue()
        {
            return 0;
        }
    }
}
