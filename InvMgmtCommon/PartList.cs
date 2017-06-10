using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common
{
    public class PartList
    {
        public List<Part> Parts;

        public PartList()
        {
            Parts = new List<Part>();
        }
        public bool Add(Part equipment)
        {
            Parts.Add(equipment);
            return true;
        }
    }
}
