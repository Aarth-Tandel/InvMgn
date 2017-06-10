using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvMgmt.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Main main = new Main();

            main.CreateMasterListOfParts(main.MLPart);
            main.PrintPartList(main.MLPart);

            main.CreateMasterListOfPens(main.MLPen);
            main.PrintPenList(main.MLPen);

            main.AddStockInInventory(main.StoreInventory);
            main.AddStockInInventory2(main.StoreInventory);

            main.RemoveStockFromInventory(main.StoreInventory);

            Console.WriteLine("{0}{1}{2}Press Enter to quit...", System.Environment.NewLine, System.Environment.NewLine, System.Environment.NewLine);
            Console.ReadLine();
        }
    }
}
