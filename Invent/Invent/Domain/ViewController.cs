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
        private Domain.InventarizationEntities4 Model = new InventarizationEntities4();
        //private List<InventoryItem> InvList = new List<InventoryItem>();
        public ViewController()
        {
            
        }

        public List<MoveStatementLocal> MoveStatements()
        {
            List<MoveStatementLocal> listok = new List<MoveStatementLocal>();
            string str = "";
            foreach (MoveStatement ms in Model.MoveStatement)
                {
                    if (ms.Subdivision1 == null) str = "";
                    else str = ms.Subdivision1.Name;
                    listok.Add(new MoveStatementLocal(ms.IDStatement, ms.StatementDate, ms.WorkerTableNum, ms.SenderSubdivisionID, ms.ReceiverSubdivisionID, ms.Subdivision.Name, str));
                }
            return listok;
        }

        public List<Inventory> ContextInventory(List<StatementContext> sc)
        {
            List<Inventory> list = new List<Inventory>();
            foreach(StatementContext s in sc)
            {
                list.Add(Model.Inventory.First(x => x.IDInventory == s.InventoryIDInventory));
            }
            return list;
        }

        public MoveStatement LastStatement()
        {
            List<MoveStatement> ml = Model.MoveStatement.ToList();
            return ml.Last();
        }
        
        public string sender(MoveStatement ms)
        {
            if(ms.SenderSubdivisionID == null)
            {
                return null;
            } else
            {
                return Model.Subdivision.First(x => x.IDSubdivision == ms.SenderSubdivisionID).Name;
            }
        }

        public string receiver(MoveStatement ms)
        {
            return Model.Subdivision.First(x => x.IDSubdivision == ms.ReceiverSubdivisionID).Name;
        }
             
        public List<StatementContext> FullStatement(MoveStatement ms)
        {
            List<StatementContext> list = Model.StatementContext.Where(x => x.MoveStatementIDStatement == ms.IDStatement).ToList();
            return list;
        }

        public List<InventoryItem> WritedOffItems()
        {
            List<InventoryItem> InvList = new List<InventoryItem>();
            List<Inventory> list = new List<Inventory>();
            List<WriteOffAct> walist = Model.WriteOffAct.ToList();
            foreach(WriteOffAct wa in walist)
            {
                list.Add(Model.Inventory.First(x => x.IDInventory == wa.IdInventory));
            }
            foreach (Inventory inv in list)
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

        public List<LocalReason> Reasons()
        {
            List<LocalReason> listik = new List<LocalReason>();
            foreach(WriteOffReason wr in Model.WriteOffReason)
            {
                LocalReason lr = new LocalReason(wr.IDReason, wr.Description);
                listik.Add(lr);
            }
            return listik;
        }

        public List<LocalObjectType> types()
        {
            List<LocalObjectType> local = new List<LocalObjectType>();
            List<ObjectType> types = Model.ObjectType.ToList();
            foreach(ObjectType t in types)
            {
                local.Add(new LocalObjectType(t.TypeID, t.TypeName));
            }
            return local;
        }

        public List<InventoryItem> AllInventory()
        {
            List<WriteOffAct> walist = Model.WriteOffAct.ToList();
            List<InventoryItem> InvList = new List<InventoryItem>();
            List<Inventory> list = Model.Inventory.ToList();
            foreach (WriteOffAct wa in walist)
            {
                Inventory inv = Model.Inventory.First(x => x.IDInventory == wa.IdInventory);
                list.Remove(inv);
            }
            foreach (Inventory inv in list)
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
            List<WriteOffAct> walist = Model.WriteOffAct.ToList();
            List<Inventory> list = Model.Inventory.ToList();
            foreach (WriteOffAct wa in walist)
            {
                Inventory inv = Model.Inventory.First(x => x.IDInventory == wa.IdInventory);
                list.Remove(inv);
            }
            List<InventoryItem> InvList = new List<InventoryItem>();
            List<DefectiveList> deflist = Model.DefectiveList.ToList();
            List<int> WritedOffIds = new List<int>();
            foreach (DefectiveList dl in deflist)
            {
                WritedOffIds.Add(dl.IDList);
            }

            foreach (Inventory inv in list)
            {
                bool flag = false;
                foreach(int ids in WritedOffIds)
                {
                    if(inv.IDInventory == ids)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    List<StatementContext> sc = Model.StatementContext.Where(x => x.InventoryIDInventory == inv.IDInventory).ToList();
                    StatementContext Sc = sc.Last();
                    Subdivision Sd = Model.MoveStatement.First(x => x.IDStatement == Sc.MoveStatementIDStatement).Subdivision;
                    string name = Sd.Name;
                    int id = Sd.IDSubdivision;
                    InventoryItem invitem = new InventoryItem(inv.IDInventory, inv.ManufactNum, inv.FullName, inv.InvNumber, inv.ReceiveDate, inv.Cost, inv.ObjectTypeTypeID, inv.ObjectType.TypeName, name, id);
                    InvList.Add(invitem);
                }
            }
            List<InventoryItem> SubInvList = InvList.Where(x => x.SubdivisionID == sd.IDSubdivision).ToList();
            return SubInvList;
        }
    }
}
