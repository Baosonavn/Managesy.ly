﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class BusinessField: EntityType
    {
        private string _Name;
        private ICollection<Customer> _Companies;

        public BusinessField()
        {
            this.Companies = new ObservableCollection<Customer>();
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != null || value != _Name) _Name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the company collection of this field
        /// </summary>
        public virtual ICollection<Customer> Companies
        {
            get { return _Companies; }
            set
            {
                if (value != null || value != _Companies) _Companies = value;
                OnPropertyChanged();
            }
        }
    }
}
