using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent.Domain
{
    public class MoveStatementLocal
    {
        private int _id;
        private DateTime _date;
        private int _tablenum;
        private int? _senderid;
        private int _receiverid;
        private string _sender;
        private string _receiver;
        public MoveStatementLocal(int id, DateTime date, int table, int? senderid, int receiverid, string sender, string receiver)
        {
            _id = id;
            _date = date;
            _tablenum = table;
            _senderid = senderid;
            _receiverid = receiverid;
            _sender = sender;
            _receiver = receiver;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        public int TableNum
        {
            get
            {
                return _tablenum;
            }
        }

        public int? SenderId
        {
            get
            {
                return _senderid;
            }
        }

        public int ReceiverId
        {
            get
            {
                return _receiverid;
            }
        }

        public string Sender
        {
            get
            {
                return _sender;
            }
        }

        public string Receiver
        {
            get
            {
                return _receiver;
            }
        }
    }
}
