using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common
{
    public class Pen
    {
        public string Name { get; set; }
        public PartList Parts;

        public Pen()
        {
            Name = "";
            Parts = new PartList();
        }

        public Pen(string name)
        {
            Name = name;
            Parts = new PartList();
        }
    }
}
