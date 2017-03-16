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
    public partial class MoveForm : Form
    {
        private ViewController Vc;
        public MoveForm(ViewController vc)
        {
            InitializeComponent();
            Vc = vc;
        }

        private void MoveForm_Load(object sender, EventArgs e)
        {
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = Vc.SubdivisionInventory(new Subdivision());
        }
    }
}
