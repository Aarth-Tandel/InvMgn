using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common.Stock
{
    public class PartInCount : Part
    {
        public int Count { get; set; }

        public PartInCount()
        {
            Count = 0;
            Type = PartTypeEnum.ptCount;
        }

        public PartInCount(int count)
        {
            Count = count;
            Type = PartTypeEnum.ptCount;
        }
    }
}
