using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent.Domain
{
    public class LocalSubdiv
    {
        private int _idSubdiv;
        private string _Name;
        private int? _idMainSubdiv;
        private int _idBuilding;
        private DateTime? _dissolutionDate;

        public LocalSubdiv(int id, string name, int? main, int building, DateTime? distime)
        {
            _idSubdiv = id;
            _Name = name;
            _idMainSubdiv = main;
            _idBuilding = building;
            _dissolutionDate = distime;
        }

        public DateTime? DissolutionDate
        {
            get
            {
                return _dissolutionDate;
            }
        }

        public int idBuilding
        {
            get
            {
                return _idBuilding;
            }
        }

        public int idSubdiv
        {
            get
            {
                return _idSubdiv;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
        }

        public int? idMainSubdiv
        {
            get
            {
                return _idMainSubdiv;
            }
        }

        public override string ToString()
        {
            return this._Name;
        }
    }
}
