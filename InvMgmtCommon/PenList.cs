using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common
{
    public class PenList
    {
        public List<Pen> Pens { get; set; }

        public PenList()
        {
            Pens = new List<Pen>();
        }

        public bool Add(Pen pen)
        {
            Pens.Add(pen);
            return true;
        }
    }
}
