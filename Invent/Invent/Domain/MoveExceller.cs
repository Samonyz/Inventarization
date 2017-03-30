using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Invent.Domain
{
    public class MoveExceller
    {
        MoveStatement _ms;
        ViewController _vc;
        string _worker;
        string _sender;
        string _receiver;
        public MoveExceller(MoveStatement ms, ViewController vc, string worker, string sender, string receiver)
        {
            _ms = ms;
            _vc = vc;
            _worker = worker;
            _sender = sender;
            _receiver = receiver;
        }

        public void MakeDocument()
        {
            List<StatementContext> list = _vc.FullStatement(_ms);
            List<Inventory> invlist = _vc.ContextInventory(list);
            Application app = new Application();
            app.Workbooks.Open(@"C:\\1.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Cells[6, "A"] = "Ухтинский Государственный Технический Университет";
            app.Cells[66, "B"] = "МОЛ";
            app.Cells[11, "P"] = _ms.IDStatement.ToString();
            app.Cells[11, "R"] = _ms.StatementDate.ToString();
            app.Cells[16, "A"] = _sender;
            app.Cells[16, "G"] = _receiver;
            app.Visible = true;
            int begin = 22;
            decimal cost = 0;
            int count = 0;
            foreach(Inventory i in invlist)
            {
                app.Cells[begin, "A"] = i.FullName;
                app.Cells[begin, "F"] = i.InvNumber.ToString();
                app.Cells[begin, "K"] = "Ед.";
                app.Cells[begin, "O"] = "1";
                app.Cells[begin, "U"] = i.Cost;
                app.Cells[begin, "W"] = i.Cost;
                begin++;
                count++;
                cost += i.Cost;
                if (begin == 35)
                {
                    begin = 42;
                    app.Cells[35, "W"] = cost;
                    app.Cells[35, "O"] = count;
                    count = 0;
                    cost = 0;
                }
                if(invlist.Count <= 13)
                {
                    app.Cells[35, "W"] = cost;
                    app.Cells[35, "O"] = count;
                }
            }
            app.Cells[63, "O"] = count;
            app.Cells[63, "W"] = cost;
            app.Cells[64, "O"] = invlist.Count;
            app.Cells[64, "W"] = invlist.Sum(x => x.Cost);
            app.Cells[70, "B"] = "Мол";
        }
    }
}
