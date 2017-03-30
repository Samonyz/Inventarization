using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invent.Domain;

namespace Invent
{
    public partial class Form1 : Form
    {
        private DataManipulationCtrl dmc = new DataManipulationCtrl();
        private ViewController vc = new ViewController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventoryItemBindingSource.DataSource = null;
            inventoryItemBindingSource.DataSource = vc.AllInventory();
            //MoveExceller me = new MoveExceller(new MoveStatement { IDStatement = 1, StatementDate = DateTime.Today, WorkerTableNum = 1, SenderSubdivisionID = null, ReceiverSubdivisionID = 1 } , vc, "ada", "Склад", "ВТИСиТ");
            //me.MakeDocument();
        }

        private void просмотрАктивовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void перемещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveForm mf = new MoveForm(vc, dmc);
            mf.Show();
        }

        private void инвентарьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void регистрацияНовогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm(vc, dmc);
            rf.ShowDialog(this);
        }

        private void внестиЗаявлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void регистрацияАктаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteOffForm wf = new WriteOffForm(vc, dmc);
            wf.Show(this);
            
        }

        private void просмотрСписанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritedOffItems woi = new WritedOffItems(vc);
            woi.Show(this);
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMoveStatements vms = new ViewMoveStatements(vc);
            vms.Show(this);
        }
    }
}
