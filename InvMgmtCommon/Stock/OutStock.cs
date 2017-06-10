using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common.Stock
{
    public class OutStock
    {
        public List<OutGoingPen> Pens { get; set; }

        public OutStock()
        {
            Pens = new List<OutGoingPen>();
        }

        public bool Add(OutGoingPen pen)
        {
            Pens.Add(pen);
            return true;
        }
    }
}
