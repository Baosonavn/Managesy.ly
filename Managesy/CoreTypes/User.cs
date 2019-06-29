using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private string _Note;
        private string _Skype;
        private string _Facebook;
        private string _PermanentAddr;
        private string _Id_Number;
        private string _Id_Place;
        private DateTime? _Id_Date;
        private string _Pp_Number;
        private string _Pp_Place;
        private DateTime? _PP_Date;
        private string _SI_Number;
        private string _PIT_Code;
        private ICollection<Education> _Educations;
        private ICollection<Experience> _Experiences;
        private ICollection<License> _Licenses;
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

        /// <summary>
        /// Get or set this user's company
        /// </summary>
        public virtual Company Company { get; set; } 

        /// <summary>
        /// Get or set this user's bank accounts
        /// </summary>
        public virtual ICollection<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// Get or set this user's education records.
        /// </summary>
        public virtual ICollection<Education> Educations
        {
            get { return _Educations; }
            set
            {
                if (value != null || value != _Educations) _Educations = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's working experiences.
        /// </summary>
        public virtual ICollection<Experience> Experiences
        {
            get { return _Experiences; }
            set
            {
                if (value != null || value != _Experiences) _Experiences = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's professional licenses
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
        #endregion

        #region FOREIGN KEY

        /// <summary>
        /// Get or set the department id of this user.
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Get or set the company id of this user.
        /// </summary>
        public int CompanyId { get; set; }
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

        /// <summary>
        /// Get or set the self note of this user
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
        /// Get or set the skype name of this user.
        /// </summary>
        public string Skype
        {
            get { return _Skype; }
            set
            {
                if (value != null || value != _Skype) _Skype = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the facebook address of this user.
        /// </summary>
        public string Facebook
        {
            get { return _Facebook; }
            set
            {
                if (value != null || value != _Facebook) _Facebook = value;
                OnPropertyChanged();
            }
        }


        /// <summary>
        /// Get or set this user's permanent address
        /// </summary>
        public string PermanentAddr
        {
            get { return _PermanentAddr; }
            set
            {
                if (value != null || value != _PermanentAddr) _PermanentAddr = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's identify number
        /// </summary>
        public string Id_Number
        {
            get { return _Id_Number; }
            set
            {
                if (value != null || value != _Id_Number) _Id_Number = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set where this user's id was issued.
        /// </summary>
        public string Id_Place
        {
            get { return _Id_Place; }
            set
            {
                if (value != null || value != _Id_Place) _Id_Place = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set when this user's id was issued.
        /// </summary>
        public DateTime? Id_Date
        {
            get { return _Id_Date; }
            set
            {
                if (value != null || value != _Id_Date) _Id_Date = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's passport number.
        /// </summary>
        public string Pp_Number
        {
            get { return _Pp_Number; }
            set
            {
                if (value != null || value != _Pp_Number) _Pp_Number = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set where this user's passport was issued.
        /// </summary>
        public string Pp_Place
        {
            get { return _Pp_Place; }
            set
            {
                if (value != null || value != _Pp_Place) _Pp_Place = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set when this user's passport was issued.
        /// </summary>
        public DateTime? Pp_Date
        {
            get { return _PP_Date; }
            set
            {
                if (value != null || value != _PP_Date) _PP_Date = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's socical issuarance book number.
        /// </summary>
        public string SI_Number
        {
            get { return _SI_Number; }
            set
            {
                if (value != null || value != _SI_Number) _SI_Number = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this user's personal income tax code.
        /// </summary>
        public string PIT_Code
        {
            get { return _PIT_Code; }
            set
            {
                if (value != null || value != _PIT_Code) _PIT_Code = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public User()
        {
            this.BankAccounts = new ObservableCollection<BankAccount>();
            this.JobTitles = new ObservableCollection<JobTitle>();
            this.Educations = new ObservableCollection<Education>();
            this.Experiences = new ObservableCollection<Experience>();
            this.Licenses = new ObservableCollection<License>();

            this.Gender = Gender.NotSet;
            this.MaritalStatus = MaritalStatus.NotSet;
            this.UserStatus = State.Inactived;

        }
    }
}
