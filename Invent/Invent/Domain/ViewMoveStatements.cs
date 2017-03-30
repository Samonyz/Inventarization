using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invent.Domain
{
    public partial class ViewMoveStatements : Form
    {
        private ViewController _vc;
        public ViewMoveStatements(ViewController vc)
        {
            InitializeComponent();
            _vc = vc;
        }

        private void ViewMoveStatements_Load(object sender, EventArgs e)
        {
            moveStatementLocalBindingSource.DataSource = null;
            moveStatementLocalBindingSource.DataSource = _vc.MoveStatements();
        }

        private void moveStatementLocalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            List<InventoryItem> invlist = new List<InventoryItem>();
            List<StatementContext> scl = _vc.FullStatement(new MoveStatement { IDStatement = (moveStatementLocalBindingSource.Current as MoveStatementLocal).Id });
            List<Inventory> listik = _vc.ContextInventory(scl);
            foreach (Inventory i in listik)
            {
                invlist.Add(new InventoryItem(i.IDInventory, i.ManufactNum, i.FullName, i.InvNumber, i.ReceiveDate, i.Cost, i.ObjectTypeTypeID, i.ObjectType.TypeName, "", 0));
            }
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = invlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveExceller me = new MoveExceller(new MoveStatement { IDStatement = (moveStatementLocalBindingSource.Current as MoveStatementLocal).Id }, _vc, "", (moveStatementLocalBindingSource.Current as MoveStatementLocal).Receiver, (moveStatementLocalBindingSource.Current as MoveStatementLocal).Sender);
            me.MakeDocument();
        }
    }
}
