using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone02
{
    class InventoryItem
    {
        private int ItemID { get; }
        private string ItemName { get; set; }
        private int QuantityOnHand { get; set; }
        private int QuantityOnOrder { get; set; } = 0;
        private decimal ItemPrice { get; set; }
        private string ItemCategory { get; set; }
        private static int totalInventoryQuantity = 1; //used to determine ITEM_ID

        //constructor
        public InventoryItem(string itemName, int quantityOnHand, int itemPrice, string itemCategory)
        {
            ItemName = itemName;
            QuantityOnHand = quantityOnHand;
            ItemPrice = itemPrice;
            ItemCategory = itemCategory;
            ItemID = totalInventoryQuantity;
            totalInventoryQuantity++;
        }

        //methods
        public void OrderItems(int howMany)
        {
            QuantityOnOrder += howMany;
        }

        public void RemoveItem(int howMany)
        {
            QuantityOnHand -= howMany;
        }

        public void AddItem(int howMany)
        {
            QuantityOnHand += howMany;
        }
    }
}
