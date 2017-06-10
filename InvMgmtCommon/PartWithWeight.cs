using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common
{
    public class PartWithWeight : Part
    {
        public float Weight;
        public PartWithWeight(string name, string description, float weight)
            : base(name, description, PartTypeEnum.ptWeight)
        {
            Weight = weight;
        }
    }
}
