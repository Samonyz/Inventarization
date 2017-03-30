using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent.Domain
{
    public class LocalReason
    {
        private int _IdReason;
        private string _Reason;
        public LocalReason(int id, string reason)
        {
            _IdReason = id;
            _Reason = reason;
        }

        public int IdReason
        {
            get
            {
                return _IdReason;
            }
        }

        public string Reason
        {
            get
            {
                return _Reason;
            }
        }

        public override string ToString()
        {
            return this._Reason;
        }
    }
}
