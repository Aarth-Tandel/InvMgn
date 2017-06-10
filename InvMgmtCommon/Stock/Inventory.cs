using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.Common.Stock
{
    public class Inventory
    {
        public Dictionary<string, Part> InvParts { get; set; }

        public Inventory()
        {
            InvParts = new Dictionary<string, Part>();
        }

        public bool AddToInventory(InStock inStock)
        {
            foreach (var item in inStock.Parts)
            {
                AddorUpdatePart(item);
            }

            return true;
        }

        public bool AddorUpdatePart(Part part)
        {
            string key = part.Name;
            if (InvParts.ContainsKey(key))
            {
                Part temp = InvParts[key];
                if (temp.Type == part.Type)
                {
                    switch (temp.Type)
                    {
                        case PartTypeEnum.ptWeight:
                            ((PartWithWeight)temp).Weight += ((PartWithWeight)part).Weight;
                            break;

                        case PartTypeEnum.ptCount:
                            ((PartWithCount)temp).Count += ((PartWithCount)part).Count;
                            break;

                        default:
                            return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                InvParts.Add(key, part);
            }

            return true;
        }

        public bool RemoveFromInventory(OutStock outStock, PenList mlPen)
        {
            foreach (var item in outStock.Pens)
            {
                DeletePart(item, mlPen);
            }

            return true;
        }

        public bool DeletePart(OutGoingPen ogPen, PenList mlPen)
        {
            bool bReturn = false;

            //string match = mlPen.Pens[1].Name;
            //for (int i = 0; i < mlPen.Pens.Count(); i++)
            foreach(var pen in mlPen.Pens)
            {
                if (pen.Name == ogPen.Name)
                {
                    //for (int j = 0; j < pen.Parts.Parts.Count(); j++)
                    foreach(var penPart in pen.Parts.Parts)
                    {
                        if (InvParts.ContainsKey(penPart.Name))
                        {
                            var invPart = InvParts[penPart.Name];
                            switch (penPart.Type)
                            {
                                case PartTypeEnum.ptWeight:
                                    ((PartWithWeight)invPart).Weight -= (((PartWithWeight)penPart).Weight * ogPen.Count);
                                    break;

                                case PartTypeEnum.ptCount:
                                    ((PartWithCount)invPart).Count -= (((PartWithCount)penPart).Count * ogPen.Count );
                                    break;

                                default:
                                    return false;
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }

                    bReturn = true;
                }
           }

            return bReturn;
        }

    }
}
