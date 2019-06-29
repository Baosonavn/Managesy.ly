using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class Bank : EntityType
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != null || value != _Name) _Name = value;
                OnPropertyChanged();
            }
        }
    }
}
