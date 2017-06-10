using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common.Stock
{
    public class PenCount : Pen
    {
        public int Count { get; set; }

        public PenCount()
        {
            Count = 0;
        }
    }
}
