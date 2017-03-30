using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent.Domain
{
    public class DataManipulationCtrl
    {
        private InventarizationEntities4 model = new InventarizationEntities4();
        public void AddItem(Inventory ii, int id)
        {
            int workerid = model.Worker.FirstOrDefault(x => x.SubdivisionID == id).TableNum;
            List<Inventory> invlist = model.Inventory.ToList();
            ii.IDInventory = invlist.Last().IDInventory + 1;
            model.Inventory.Add(ii);
            MoveStatement ms = new MoveStatement();
            StatementContext sc = new StatementContext();
            sc.InventoryIDInventory = ii.IDInventory;
            List<MoveStatement> msl = model.MoveStatement.ToList();
            ms.IDStatement = msl.Last().IDStatement + 1;
            ms.SenderSubdivisionID = null;
            ms.ReceiverSubdivisionID = id;
            ms.WorkerTableNum = workerid;
            ms.StatementDate = DateTime.Today;
            model.MoveStatement.Add(ms);
            sc.MoveStatementIDStatement = ms.IDStatement;
            model.StatementContext.Add(sc);
            model.SaveChanges();
        }

        public void moveItem(List<InventoryItem> il, int sender, int receiver)
        {
            MoveStatement ms = new MoveStatement();
            int workerid = model.Worker.FirstOrDefault(x => x.SubdivisionID == sender).TableNum;
            List<MoveStatement> msl = model.MoveStatement.ToList();
            ms.IDStatement = msl.Last().IDStatement + 1;
            ms.SenderSubdivisionID = sender;
            ms.ReceiverSubdivisionID = receiver;
            ms.WorkerTableNum = workerid;
            ms.StatementDate = DateTime.Today;
            model.MoveStatement.Add(ms);
            model.SaveChanges();
            foreach (InventoryItem ii in il)
            {
                StatementContext sc = new StatementContext();
                sc.InventoryIDInventory = ii.IDInventory;
                sc.MoveStatementIDStatement = ms.IDStatement;
                model.StatementContext.Add(sc);
                model.SaveChanges();
            }
        }

        public void WriteOff(InventoryItem ii, int reason)
        {
            int num;
            if(model.WriteOffAct.Count() == 0)
            {
                num = 1;
            } else
            {
                List<WriteOffAct> walist = model.WriteOffAct.ToList();
                num = walist.Last().IDWriteOffAct + 1;
            }
            //int num = walist.Last().IDWriteOffAct + 1;
            WriteOffAct wa = new WriteOffAct();
            wa.IdInventory = ii.IDInventory;
            wa.IDWriteOffAct = num;
            wa.WriteOffReasonIDReason = reason;
            model.WriteOffAct.Add(wa);
            model.SaveChanges();
        }
    }
}
