using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class LicenseType : EntityType
    {
        private string _TypeName;
        private string _ProfessionalArea;
        private ICollection<License> _Licenses;
        private string _DefaultIssuer;

        /// <summary>
        /// Get or set the license type name.
        /// </summary>
        public string TypeName
        {
            get { return _TypeName; }
            set
            {
                if (value != null || value != _TypeName) _TypeName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the professional area of this license type.
        /// </summary>
        public string ProfessionalArea
        {
            get { return _ProfessionalArea; }
            set
            {
                if (value != null || value != _ProfessionalArea) _ProfessionalArea = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the license collection of this type
        /// </summary>
        public virtual ICollection<License> Licenses
        {
            get { return _Licenses; }
            set
            {
                if (value != null || value != _Licenses) _Licenses = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the name of the issuer 
        /// </summary>
        public string DefaultIssuer
        {
            get { return _DefaultIssuer; }
            set
            {
                if (value != null || value != _DefaultIssuer) _DefaultIssuer = value;
                OnPropertyChanged();
            }
        }

        public LicenseType()
        {
            this.Licenses = new ObservableCollection<License>();
        }
    }

    public class License: EntityType
    {
        private string _Number;
        private DateTime? _DateOfIssue;
        private bool _WillExpire;
        private DateTime? _DateOfExpiration;
        private string _Issuer;

        /// <summary>
        /// Get or set this license number
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
        /// Get or set this license's date of issue.
        /// </summary>
        public DateTime? DateOfIssue
        {
            get { return _DateOfIssue; }
            set
            {
                if (value != null || value != _DateOfIssue) _DateOfIssue = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set if this license will expire
        /// </summary>
        public bool WillExpire
        {
            get { return _WillExpire; }
            set
            {
                if (value != _WillExpire) _WillExpire = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this license's date of experiation
        /// </summary>
        public DateTime? DateOfExpiration
        {
            get { return _DateOfExpiration; }
            set
            {
                if (value != null || value != _DateOfExpiration) _DateOfExpiration = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this license's insuer name
        /// </summary>
        public string Issuer
        {
            get { return _Issuer; }
            set
            {
                if (value != null || value != _Issuer) _Issuer = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the User that own this license.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Get or set the id of this license's owner.
        /// </summary>
        public int UserId { get; set; }
    }
}
