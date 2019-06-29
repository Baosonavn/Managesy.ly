using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class BankAccount: EntityType
    {
        private Bank _Bank;
        private int _BankId;
        private string _AccountOwner;
        private string _Number;
        private string _Branch;

        /// <summary>
        /// Get or set the bank of this account.
        /// </summary>
        public Bank Bank
        {
            get { return _Bank; }
            set
            {
                if (value != null || value != _Bank) _Bank = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the name of this account's owner.
        /// </summary>
        public string AccountOwner
        {
            get { return _AccountOwner; }
            set
            {
                if (value != null || value != _AccountOwner) _AccountOwner = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the account number
        /// </summary>
        public string Number
        {
            get { return _Number; }
            set
            {
                if (value != null || value != _Number) _Number = value;
                OnPropertyChanged();
            }
        }


        /// <summary>
        /// Get or set the bank branch
        /// </summary>
        public string Branch
        {
            get { return _Branch; }
            set
            {
                if (value != null || value != _Branch) _Branch = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the bank id of this account
        /// </summary>
        public int BankId
        {
            get { return _BankId; }
            set
            {
                if (value != _BankId) _BankId = value;
                OnPropertyChanged();
            }
        }
    }
}
