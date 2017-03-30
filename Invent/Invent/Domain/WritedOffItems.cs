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
    public partial class WritedOffItems : Form
    {
        private List<InventoryItem> list;
        private ViewController _vc;
        public WritedOffItems(ViewController vc)
        {
            InitializeComponent();
            _vc = vc;
        }

        private void WritedOffItems_Load(object sender, EventArgs e)
        {
            list = _vc.WritedOffItems();
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = list;
        }
    }
}
