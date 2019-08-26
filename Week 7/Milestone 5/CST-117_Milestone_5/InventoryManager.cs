using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Milestone_5
{
    class InventoryManager
    {
        //Fields
        private List<string> _listStore; //used list to Store rather then single vars


        //Constructor
        public InventoryManager()
        {
            _listStore = new List<string>() { "", "", "", "" };

        }
        //Name Property
        public string Name
        {
            get { return _listStore[0]; }
            set { _listStore[0] = value; }
        }
        //Quant Property
        public string Quant
        {
            get { return _listStore[1]; }
            set { _listStore[1] = value; }
        }
        //Product ID Property
        public string ProdId
        {
            get { return _listStore[2]; }
            set { _listStore[2] = value; }
        }
        //Price Property
        public string Price
        {
            get { return _listStore[3]; }
            set { _listStore[3] = value; }
        }
    }
}
