using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invent.Domain
{
    public class ViewController
    {
        private Domain.InventarizationEntities3 Model = new InventarizationEntities3();
        private List<InventoryItem> InvList = new List<InventoryItem>();
        public ViewController()
        {
            foreach(Inventory inv in Model.Inventory)
            {
                InventoryItem invitem = new InventoryItem(inv.IDInventory, inv.ManufactNum, inv.FullName, inv.InvNumber, inv.ReceiveDate, inv.Cost, inv.ObjectTypeTypeID, inv.ObjectType.TypeName);
                InvList.Add(invitem);
            }
        }
        public List<InventoryItem> invList
        {
            get
            {
                return InvList;
            }
        }


    }
}
