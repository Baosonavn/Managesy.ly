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
        private Customer _Company;
        private User _User;

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

        public Guid BankGuid { get; set; }

        /// <summary>
        /// Get or set the company that own this bank account
        /// </summary>
        public virtual Customer Company
        {
            get { return _Company; }
            set
            {
                if (value != null || value != _Company) _Company = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the owning company's id
        /// </summary>
        public int?  CompanyId { get; set; }

        /// <summary>
        /// Get or set the owning company's Guid
        /// </summary>
        public Guid? CompanyGuid { get; set; }

        /// <summary>
        /// Get or set the user that own this bank account
        /// </summary>
        public virtual User User
        {
            get { return _User; }
            set
            {
                if (value != null || value != _User) _User = value;
                OnPropertyChanged();
            }
        }


        /// <summary>
        /// Get or set the owning user's id
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Get or set the owning user's Guid
        /// </summary>
        public Guid? UserGuid { get; set; }

    }
}
