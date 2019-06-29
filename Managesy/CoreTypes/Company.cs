using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTypes.Enums.Company;

namespace CoreTypes
{
    public class Company: EntityType
    {

        #region FIELDS
        private string _Name;
        private string _ShortName;
        private string _TaxCode;
        private Enums.Company.Type _Type;
        private ICollection<Department> _Departments;
        private ICollection<Company> _Customers;
        private string _Address;
        private string _PhoneNumber;
        private string _Email;
        private string _Website;
        private ICollection<User> _Users;
        private string _Note;
        private ICollection<BusinessField> _BusinessFields;
        private ICollection<BankAccount> _BankAccounts;
        #endregion 

        #region REQUIRED PROPERTIES

        /// <summary>
        /// Get or set name of this Company
        /// </summary>
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
        /// Get or set short name of this Company.
        /// </summary>
        public string ShortName
        {
            get { return _ShortName; }
            set
            {
                if (value != null || value != _ShortName) _ShortName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the note of this Company.
        /// </summary>
        public string Note
        {
            get { return _Note; }
            set
            {
                if (value != null || value != _Note) _Note = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the tax code of this company
        /// </summary>
        public string TaxCode
        {
            get { return _TaxCode; }
            set
            {
                if (value != null || value != _TaxCode) _TaxCode = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the type of this company
        /// </summary>
        public Enums.Company.Type Type
        {
            get { return _Type; }
            set
            {
                if (value != _Type) _Type = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the address of this company.
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set
            {
                if (value != null || value != _Address) _Address = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the phone number of this company.
        /// </summary>
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                if (value != null || value != _PhoneNumber) _PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the email address of this company.
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set
            {
                if (value != null || value != _Email) _Email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the website address of this company.
        /// </summary>
        public string Website
        {
            get { return _Website; }
            set
            {
                if (value != null || value != _Website) _Website = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Get or set the department collection of this company.
        /// </summary>
        public virtual ICollection<Department> Departments
        {
            get { return _Departments; }
            set
            {
                if (value != null || value != _Departments) _Departments = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the customers collection of this company.
        /// </summary>
        public virtual ICollection<Company> Customers
        {
            get { return _Customers; }
            set
            {
                if (value != null || value != _Customers) _Customers = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the user collection of this company.
        /// </summary>
        public virtual ICollection<User> Users
        {
            get { return _Users; }
            set
            {
                if (value != null || value != _Users) _Users = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the business fields of this company.
        /// </summary>
        public virtual ICollection<BusinessField> BusinessFields
        {
            get { return _BusinessFields; }
            set
            {
                if (value != null || value != _BusinessFields) _BusinessFields = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the bank accounts of this company.
        /// </summary>
        public virtual ICollection<BankAccount> BankAccounts
        {
            get { return _BankAccounts; }
            set
            {
                if (value != null || value != _BankAccounts) _BankAccounts = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public Company()
        {
            this.Departments = new ObservableCollection<Department>();
            this.Customers = new ObservableCollection<Company>();
            this.BusinessFields = new ObservableCollection<BusinessField>();
            this.BankAccounts = new ObservableCollection<BankAccount>();
            this.Users = new ObservableCollection<User>();
            this.Type = Enums.Company.Type.Customer;
        }
    }
}
