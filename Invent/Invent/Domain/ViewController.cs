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
        //private List<InventoryItem> InvList = new List<InventoryItem>();
        public ViewController()
        {
            
        }

        public List<InventoryItem> AllInventory()
        {
            List<InventoryItem> InvList = new List<InventoryItem>();
            foreach (Inventory inv in Model.Inventory)
            {
                List<StatementContext> sc = Model.StatementContext.Where(x => x.InventoryIDInventory == inv.IDInventory).ToList();
                StatementContext Sc = sc.Last();
                Subdivision sd = Model.MoveStatement.First(x => x.IDStatement == Sc.MoveStatementIDStatement).Subdivision;
                string name = sd.Name;
                int id = sd.IDSubdivision;
                InventoryItem invitem = new InventoryItem(inv.IDInventory, inv.ManufactNum, inv.FullName, inv.InvNumber, inv.ReceiveDate, inv.Cost, inv.ObjectTypeTypeID, inv.ObjectType.TypeName, name, id);
                InvList.Add(invitem);
            }
            return InvList;
        }

        public List<LocalSubdiv> subdivs()
        {
            List<LocalSubdiv> list = new List<LocalSubdiv>();
            foreach(Subdivision s in Model.Subdivision)
            {
                list.Add(new LocalSubdiv(s.IDSubdivision, s.Name, s.MainSubdivisionID, s.BuildingIDBuilding, s.DissolutionDate));
            }
            return list;
        }

        public Subdivision getSubdivOnId(int id)
        {
            Subdivision sd = Model.Subdivision.FirstOrDefault(x => x.IDSubdivision == id);
            return sd;
        }

        public List<InventoryItem> SubdivisionInventory(Subdivision sd)
        {
            List<InventoryItem> InvList = new List<InventoryItem>();
            foreach (Inventory inv in Model.Inventory)
            {
                List<StatementContext> sc = Model.StatementContext.Where(x => x.InventoryIDInventory == inv.IDInventory).ToList();
                StatementContext Sc = sc.Last();
                Subdivision Sd = Model.MoveStatement.First(x => x.IDStatement == Sc.MoveStatementIDStatement).Subdivision;
                string name = Sd.Name;
                int id = Sd.IDSubdivision;
                InventoryItem invitem = new InventoryItem(inv.IDInventory, inv.ManufactNum, inv.FullName, inv.InvNumber, inv.ReceiveDate, inv.Cost, inv.ObjectTypeTypeID, inv.ObjectType.TypeName, name, id);
                InvList.Add(invitem);
            }
            List<InventoryItem> SubInvList = InvList.Where(x => x.SubdivisionID == sd.IDSubdivision).ToList();
            return SubInvList;
        }

    }
}
