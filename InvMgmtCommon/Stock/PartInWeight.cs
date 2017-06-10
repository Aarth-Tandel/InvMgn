using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common.Stock
{
    public class PartInWeight : Part
    {
        public float Weight { get; set; }
        //public PartList Parts;

        public PartInWeight()
        {
            Weight = 0.0f;
            Type = Type = PartTypeEnum.ptWeight;
            //Parts = new PartList();
        }

        public PartInWeight(float weight)
        {
            Weight = weight;
            Type = PartTypeEnum.ptWeight;
            //Parts = new PartList();
        }
    }
}
