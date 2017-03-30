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
        private List<InventoryItem> listik;
        List<InventoryItem> sendlist = new List<InventoryItem>();
        private DataManipulationCtrl _dmc;
        public MoveForm(ViewController vc, DataManipulationCtrl dmc)
        {
            InitializeComponent();
            Vc = vc;
            list = Vc.subdivs();
            _dmc = dmc;
        }

        private void MoveForm_Load(object sender, EventArgs e)
        {
            localSubdivBindingSource.DataSource = null;
            localSubdivBindingSource.DataSource = list;
            localSubdivBindingSource1.DataSource = null;
            localSubdivBindingSource1.DataSource = list;
            inventoryItemBindingSource.DataSource = null;
            listik = Vc.SubdivisionInventory(Vc.getSubdivOnId((localSubdivBindingSource.Current as LocalSubdiv).idSubdiv));
            var count = listik.Count();
            inventoryItemBindingSource.DataSource = listik;
            label2.Text = "Всего единиц зарегистрировано: " + count.ToString();

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
            listik = Vc.SubdivisionInventory(sd);
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = listik;
            label2.Text = "Всего единиц зарегистрировано: " + listik.Count.ToString();
            //CountLb.Text = nl.Count.ToString();
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
            _dmc.moveItem(sendlist, ((localSubdivBindingSource.Current as LocalSubdiv).idSubdiv), ((localSubdivBindingSource1.Current as LocalSubdiv).idSubdiv));
            MoveExceller me = new MoveExceller(Vc.LastStatement(), Vc, " ", Vc.sender(Vc.LastStatement()), Vc.receiver(Vc.LastStatement()));
            me.MakeDocument();
            MessageBox.Show("Перемещение удачно!");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            sendlist.Add((inventoryItemBindingSource.Current as InventoryItem));
            inventoryItemBindingSource1.DataSource = null;
            inventoryItemBindingSource1.DataSource = sendlist;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
