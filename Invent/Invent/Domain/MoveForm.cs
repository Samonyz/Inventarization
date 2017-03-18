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
        private List<LocalSubdiv> list;
        private ViewController Vc;
        public MoveForm(ViewController vc)
        {
            InitializeComponent();
            Vc = vc;
            list = Vc.subdivs();
        }

        private void MoveForm_Load(object sender, EventArgs e)
        {
            localSubdivBindingSource.DataSource = null;
            localSubdivBindingSource.DataSource = list;
            localSubdivBindingSource1.DataSource = null;
            localSubdivBindingSource1.DataSource = list;
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = Vc.SubdivisionInventory(Vc.getSubdivOnId((localSubdivBindingSource.Current as LocalSubdiv).idSubdiv));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((localSubdivBindingSource.Current as LocalSubdiv).Name + " " + (localSubdivBindingSource.Current as LocalSubdiv).idSubdiv);
        }

        private void inventoryItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
            
        }

        private void localSubdivBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var id = (localSubdivBindingSource.Current as LocalSubdiv).idSubdiv;
            Subdivision sd = Vc.getSubdivOnId(id);
            List<InventoryItem> nl = Vc.SubdivisionInventory(sd);
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = nl;
            CountLb.Text = nl.Count.ToString();
        }

        private void DoMovebtn_Click(object sender, EventArgs e)
        {
            if ((localSubdivBindingSource.Current as LocalSubdiv).idSubdiv == (localSubdivBindingSource1.Current as LocalSubdiv).idSubdiv)
            {
                MessageBox.Show("Структурные подразделения не должны совпадать!");
            }
            else DoMove();
        }

        private void DoMove()
        {
            throw new NotImplementedException();
        }
    }
}
