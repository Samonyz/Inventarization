using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent.Domain
{
    public class LocalObjectType
    {
        private int _typeId;
        private string _typeName;
        public LocalObjectType(int type, string typeName)
        {
            _typeId = type;
            _typeName = typeName;
        }

        public int TypeId
        {
            get
            {
                return _typeId;
            }
        }

        public string TypeName
        {
            get
            {
                return _typeName;
            }
        }

        public override string ToString()
        {
            return this._typeName;
        }
    }
}
