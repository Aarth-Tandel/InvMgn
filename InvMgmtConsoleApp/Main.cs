using InvMgmt.Common;
using InvMgmt.Common.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.UI.ConsoleApp
{
    public class Main
    {
        public PenList MLPen { get; set; }
        public PartList MLPart { get; set; }
        public Inventory StoreInventory { get; set; }

        public Main()
        {
            MLPen = new PenList();
            MLPart = new PartList();
            StoreInventory = new Inventory();
        }

        public void CreateMasterListOfPens(PenList penList)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("PRINTING all Pens...");

            Pen tempPen = new Pen();
            tempPen.Name = "Fasto";
            tempPen.Parts.Add(new PartWithWeight("Fasto Cap", "Fasto's pen cap", 0.01f));
            tempPen.Parts.Add(new PartWithWeight("Fasto Barrel", "Fasto's pen Barrel", 0.050f));
            tempPen.Parts.Add(new PartWithCount("Fasto Refill", "Fasto's pen Refill", 1));
            penList.Add(tempPen);

            tempPen = new Pen("Gripper");
            tempPen.Parts.Add(new PartWithWeight("Gripper Cap", "Gripper's pen cap", 0.020f));
            tempPen.Parts.Add(new PartWithWeight("Gripper Barrel", "Gripper's pen Barrel", 0.060f));
            tempPen.Parts.Add(new PartWithCount("Gripper Sticker", "Gripper's pen Sticker", 1));
            tempPen.Parts.Add(new PartWithCount("Gripper Refill", "Gripper's pen Refill", 1));
            penList.Add(tempPen);
        }

        public void CreateMasterListOfParts(PartList partList)
        {
            Part itemTemp = new PartWithWeight("Fasto Cap", "Fasto's pen cap", 0.010f);
            partList.Add(itemTemp);

            itemTemp = new PartWithWeight("Fasto Barrel", "Fasto's pen Barrel", 0.050f);
            partList.Add(itemTemp);

            itemTemp = new PartWithCount("Fasto Refill", "Fasto's pen Refill", 1);
            partList.Add(itemTemp);
        }

        public void PrintPenList(PenList penList)
        {
            foreach (var itemTemp in penList.Pens)
            {
                System.Console.WriteLine("Pen: '{0}'", itemTemp.Name);
                PrintPartList(itemTemp.Parts);
            }
        }

        public void PrintPartList(PartList partList)
        {
            foreach (var itemTemp in partList.Parts)
            {
                //if (itemTemp.Type == PartTypeEnum.ptWeight)
                if (itemTemp is PartWithWeight)
                {
                    PartWithWeight item = (PartWithWeight)itemTemp;
                    System.Console.WriteLine("    By Weight Part -> Name: '{0}', Description: '{1}', Weight: {2}",
                        item.Name, item.Description, item.Weight);
                }

                if (itemTemp is PartWithCount)
                {
                    PartWithCount item = (PartWithCount)itemTemp;
                    System.Console.WriteLine("    By Count Part -> Name: '{0}', Description: '{1}', Count: {2}",
                        item.Name, item.Description, item.Count);
                }
            }
        }

        public void AddInStock(InStock stock)
        {
            PartInWeight tempWeight = new PartInWeight();
            tempWeight.Name = "Fasto Cap";
            tempWeight.Weight = 100.0f;
            Console.WriteLine("Part coming in Weight: '{0}', Weight: '{1}'",tempWeight.Name,tempWeight.Weight);
            //tempWeight.Parts.Add(new PartWithWeight("Fasto Cap", "Fasto's pen cap", 1.0f));
            //tempWeight.Parts.Add(new PartWithWeight("Fasto Barrel", "Fasto's pen Barrel", 1.0f));
            stock.Add(tempWeight);

            PartInCount tempCount = new PartInCount();
            tempCount.Name = "Fasto Refill";
            tempCount.Count = 100;
            Console.WriteLine("Part coming in Count: '{0}', Count: '{1}'", tempCount.Name, tempCount.Count);
            //tempCount.Parts.Add(new PartWithWeight("Fasto Refill", "Fasto's pen refill", 1));
            stock.Add(tempCount);
        }

        public void AddOutStock(OutStock stock)
        {
            OutGoingPen tempPen = new OutGoingPen();
            tempPen.Name = "Fasto";
            tempPen.Count = 100;
            Console.WriteLine("Parts going out: '{0}', Quantity: '{1}'",tempPen.Name,tempPen.Count);
            stock.Add(tempPen);

            tempPen = new OutGoingPen();
            tempPen.Name = "Gripper";
            tempPen.Count = 100;
            Console.WriteLine("Parts going out: '{0}', Quantity: '{1}'", tempPen.Name, tempPen.Count);
            stock.Add(tempPen);
        }

        public void AddStockInInventory(Inventory stock)
        {
            PartWithWeight partWithWeight;
            PartWithCount partWithCount;

            InStock inStock = new InStock();

            partWithWeight = new PartWithWeight("Fasto Cap", "", 10.0f);
            inStock.Add(partWithWeight);

            partWithWeight = new PartWithWeight("Fasto Barrel", "", 15.0f);
            inStock.Add(partWithWeight);

            partWithWeight = new PartWithWeight("Gripper Cap", "", 5.0f);
            inStock.Add(partWithWeight);

            partWithCount = new PartWithCount("Fasto Refill", "", 1000);
            inStock.Add(partWithCount);
            Console.WriteLine("");
            StoreInventory.AddToInventory(inStock);
        }

        public void AddStockInInventory2(Inventory stock)
        {
            PartWithWeight partWithWeight;

            InStock inStock = new InStock();

            partWithWeight = new PartWithWeight("Fasto Cap", "", 4.5f);
            inStock.Add(partWithWeight);

            StoreInventory.AddToInventory(inStock);
        }

        public void RemoveStockFromInventory(Inventory stock)
        {
            OutGoingPen tempPen = new OutGoingPen();
            OutStock outStock = new OutStock();
            tempPen.Name = "Fasto1";
            tempPen.Count = 100;
            outStock.Add(tempPen);

            tempPen = new OutGoingPen();
            tempPen.Name = "Gripper";
            tempPen.Count = 50;
            outStock.Add(tempPen);

            StoreInventory.RemoveFromInventory(outStock, MLPen);
        }
    }
}
