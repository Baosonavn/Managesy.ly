using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTypes.Enums;
using CoreTypes.Enums.User;

namespace CoreTypes
{
    public class User : EntityType
    {

        #region FIELDS
        private string _Name;
        private string _Surname;
        private string _Password;
        private string _Email;
        private string _Mobile;
        private DateTime? _LastLogin;
        private State _UserStatus;
        private string _Address;
        private DateTime? _BirthDay;
        private DateTime? _FirstDayAtWork;
        private DateTime? _LastDayAtWork;
        private string _AvatarUrl;
        private Gender _Gender;
        private MaritalStatus _MaritalStatus;
        #endregion

        #region REQUIRED PROPERTIES
        /// <summary>
        /// Get or set the Name of this User.
        /// </summary>
        [Required]
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != null || value != _Name) _Name = value;
                this.OnPropertyChanged("Name");
                this.OnPropertyChanged("FullName");
            }
        }

        /// <summary>
        /// Get or set the surname of this user.
        /// </summary>
        [Required]
        public string Surname
        {
            get { return _Surname; }
            set
            {
                if (value != null || value != _Surname) _Surname = value;
                this.OnPropertyChanged("Surname");
                this.OnPropertyChanged("FullName");
            }
        }

        /// <summary>
        /// Get the fullname of this user.
        /// </summary>
        [NotMapped]
        public string FullName
        {
            get { return Surname + " " + Name; }
        }

        /// <summary>
        /// Get or set the password of this user.
        /// Shoud be hashed.
        /// </summary>
        [Required]
        public string Password
        {
            get { return _Password; }
            set
            {
                if (value != null || value != _Password) _Password = value;
                OnPropertyChanged("Password");
            }
        }

        /// <summary>
        /// Get or set the email address of this user. Shoud be unique.
        /// </summary>
        [Required]
        public string Email
        {
            get { return _Email; }
            set
            {
                if (value != null || value != _Email) _Email = value;
                OnPropertyChanged("Email");
            }
        }
        #endregion

        #region OPTIONAL PROPERTIES
        /// <summary>
        /// Get or set the mobile phone number of this user.
        /// </summary>
        public string Mobile
        {
            get { return _Mobile; }
            set
            {
                if (value != null || value != _Mobile) _Mobile = value;
                OnPropertyChanged("Mobile");
            }
        }

        /// <summary>
        /// Get or set the time this user login
        /// </summary>
        public DateTime? LastLogin
        {
            get { return _LastLogin; }
            set
            {
                if (value != null || value != _LastLogin) _LastLogin = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the status of this user. 
        /// Default = Inactived
        /// </summary>
        public State UserStatus
        {
            get { return _UserStatus; }
            set
            {
                if (value != _UserStatus) _UserStatus = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the gender of this user
        /// </summary>
        public Gender Gender
        {
            get { return _Gender; }
            set
            {
                if (value != _Gender) _Gender = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the marital status of this user
        /// </summary>
        public MaritalStatus MaritalStatus
        {
            get { return _MaritalStatus; }
            set
            {
                if (value != _MaritalStatus) _MaritalStatus = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Get the department of this user.
        /// </summary>
        public virtual Department Department { get; }

        /// <summary>
        /// Get or set this user's job titles
        /// </summary>
        public virtual ICollection<JobTitle> JobTitles { get; set; }

        #endregion

        #region FOREIGN KEY

        /// <summary>
        /// Get or set the department id of this user.
        /// </summary>
        public int DepartmentId { get; set; }

        #endregion

        #region Some personal information

        /// <summary>
        /// Get or set the address of this user.
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
        /// Get or set the day of birth of this user
        /// </summary>
        public DateTime? BirthDay
        {
            get { return _BirthDay; }
            set
            {
                if (value != null || value != _BirthDay) _BirthDay = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's first day at AVN
        /// </summary>
        public DateTime? FirstDayAtWork
        {
            get { return _FirstDayAtWork; }
            set
            {
                if (value != null || value != _FirstDayAtWork) _FirstDayAtWork = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's last day at AVN
        /// </summary>
        public DateTime? LastDayAtWork
        {
            get { return _LastDayAtWork; }
            set
            {
                if (value != null || value != _LastDayAtWork) _LastDayAtWork = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the url to this user's avatar
        /// </summary>
        public string AvatarUrl
        {
            get { return _AvatarUrl; }
            set
            {
                if (value != null || value != _AvatarUrl) _AvatarUrl = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
