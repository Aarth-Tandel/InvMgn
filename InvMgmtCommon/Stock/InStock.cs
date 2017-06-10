using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common.Stock
{
    public class InStock
    {
        public List<Part> Parts { get; set; }

        public InStock()
        {
            Parts = new List<Part>();
        }

        public bool Add(Part part)
        {
            Parts.Add(part);
            return true;
        }
    }
}
