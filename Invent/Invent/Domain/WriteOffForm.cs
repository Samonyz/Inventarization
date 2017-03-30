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
    public partial class WriteOffForm : Form
    {
        private ViewController _vc;
        private DataManipulationCtrl _dmc;
        public WriteOffForm(ViewController vc, DataManipulationCtrl dmc)
        {
            InitializeComponent();
            _vc = vc;
            _dmc = dmc;
        }

        private void WriteOffForm_Load(object sender, EventArgs e)
        {
            localSubdivBindingSource.DataSource = null;
            localSubdivBindingSource.DataSource = _vc.subdivs();
            localReasonBindingSource.DataSource = null;
            localReasonBindingSource.DataSource = _vc.Reasons();
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = _vc.SubdivisionInventory(_vc.getSubdivOnId((localSubdivBindingSource.Current as LocalSubdiv).idSubdiv));
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _dmc.WriteOff((inventoryItemBindingSource.Current as InventoryItem), (localReasonBindingSource.Current as LocalReason).IdReason);
            MessageBox.Show("Списание успешно");
        }
    }
}
