using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent.Domain
{
    public class InventoryItem
    {
        private int _IDInventory;
        private int _ManufactNum;
        private string _FullName;
        private int _InvNumber;
        private DateTime _ReceiveDate;
        private decimal _Cost;
        private int _ObjectType;
        private string _ObjectName;
        private string _Subdivision;
        private int _SubdivisionID;

        public InventoryItem(int idinv, int manufact, string fullname, int invnum, DateTime receive, decimal cost, int objtype, string objname, string subdiv, int subid)
        {
            _IDInventory = idinv;
            _ManufactNum = manufact;
            _FullName = fullname;
            _InvNumber = invnum;
            _ReceiveDate = receive;
            _Cost = cost;
            _ObjectType = objtype;
            _ObjectName = objname;
            _Subdivision = subdiv;
            _SubdivisionID = subid;
        }

        public int SubdivisionID
        {
            get
            {
                return _SubdivisionID;
            }
        }

        public string Subdivision
        {
            get
            {
                return _Subdivision;
            }
        }

        public int IDInventory
        {
            get
            {
                return _IDInventory;
            }
        }

        public int ManufactNum
        {
            get
            {
                return _ManufactNum;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }
        }

        public int InvNumber
        {
            get
            {
                return _InvNumber;
            }
        }

        public DateTime ReceiveDate
        {
            get
            {
                return _ReceiveDate;
            }
        }

        public decimal Cost
        {
            get
            {
                return _Cost;
            }
        }

        public int ObjectType
        {
            get
            {
                return _ObjectType;
            }
        }

        public string ObjectName
        {
            get
            {
                return _ObjectName;
            }
        }
    }
}
