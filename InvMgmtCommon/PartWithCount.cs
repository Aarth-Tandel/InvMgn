using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common
{
    public class PartWithCount : Part
    {
        public int Count;
        public PartWithCount(string name, string description, int count)
            : base(name, description, PartTypeEnum.ptCount)
        {
            Count = 1;
        }
    }
}
