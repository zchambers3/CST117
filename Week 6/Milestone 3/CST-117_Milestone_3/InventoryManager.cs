using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Milestone_3
{
    class InventoryManager
    {
        //Fields
        private string _name;
        private int _quant;
        private string _prodId;
        private decimal _price;


        //Constructor
        public InventoryManager()
        {
            _name = "";
            _quant = 0;
            _prodId = "";
            _price = 0m;
        }
        //Name Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //Quant Property
        public int Quant
        {
            get { return _quant; }
            set { _quant = value; }
        }
        //Product ID Property
        public string ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }
        //Price Property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
