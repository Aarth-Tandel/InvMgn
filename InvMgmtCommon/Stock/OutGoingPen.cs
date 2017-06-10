using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common.Stock
{
    public class OutGoingPen
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public OutGoingPen()
        {
            Name = "";
            Count = 0;
        }

        public OutGoingPen(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}
