using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common
{
    public class Part
    {
        public PartTypeEnum Type;
        public string Name;
        public string Description;

        public Part()
        {
            Name = "";
            Description = "";
            Type = PartTypeEnum.ptNone;
        }

        public Part(string name, string description, PartTypeEnum type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
