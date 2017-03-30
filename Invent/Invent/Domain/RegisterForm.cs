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
    public partial class RegisterForm : Form
    {
        private ViewController _vc;
        private DataManipulationCtrl _dmc;
        private List<LocalObjectType> local;
        private List<LocalSubdiv> _subdivs;
        public RegisterForm(ViewController vc, DataManipulationCtrl dmc)
        {
            InitializeComponent();
            _vc = vc;
            _dmc = dmc;
            localObjectTypeBindingSource.DataSource = null;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            _subdivs = _vc.subdivs();
            local = _vc.types();
            localObjectTypeBindingSource.DataSource = local;
            localSubdivBindingSource.DataSource = _subdivs;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            int subid = (localSubdivBindingSource.Current as LocalSubdiv).idSubdiv;
            Inventory inv = new Inventory();
            inv.InvNumber = Convert.ToInt32(InvNumberTb.Text);
            inv.ManufactNum = Convert.ToInt32(ManufactNumberTb.Text);
            inv.Cost = Convert.ToDecimal(CostTb.Text);
            inv.ReceiveDate = DateTime.Today;
            inv.FullName = FullNameTb.Text.ToString();
            inv.ObjectTypeTypeID = (localObjectTypeBindingSource.Current as LocalObjectType).TypeId;
            _dmc.AddItem(inv, subid);
            MessageBox.Show("Внесение успешно");
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
