using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    interface IInventory
    {
        void Update(int productId);
    }


    class InventoryManager : IInventory
    {
        public void Update(int productno)
        {
            Console.WriteLine(string.Format("Product# {0} is subtracted from the store's inventory." , productno));
        }
    }
}
