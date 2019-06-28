using CoreTypes.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class Department: EntityType
    {
        #region FIELDS
        private string _Name;
        private string _Description;
        private Department _ParentDepartment;
        private ICollection<Department> _ChildDepartments;
        private Status _Status;
        private User _HeadUser;
        private User _ViceUser;
        #endregion

        public Department()
        {
            this.Users = new ObservableCollection<User>();
            this.ChildDepartments = new ObservableCollection<Department>();
            this.Status = Status.Actived;
        }

        #region REQUIRED PROPERTIES

        /// <summary>
        /// Get or set the name of this department.
        /// </summary>
        [Required]
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
        /// Status of this department
        /// </summary>
        [Required]
        public Enums.Status Status
        {
            get { return _Status; }
            set
            {
                if (value != _Status) _Status = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region OPTIONAL PROPERTIES

        /// <summary>
        /// Get or set the description of this department.
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set
            {
                if (value != null || value != _Description) _Description = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// The collection of user in this department.
        /// </summary>
        public ICollection<User> Users { get; private set; }

        /// <summary>
        /// Get or set the super department of this department.
        /// </summary>
        public virtual Department ParentDepartment
        {
            get { return _ParentDepartment; }
            set
            {
                if (value != null || value != _ParentDepartment) _ParentDepartment = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the child department of this department
        /// </summary>
        public ICollection<Department> ChildDepartments
        {
            get { return _ChildDepartments; }
            set
            {
                if (value != null || value != _ChildDepartments) _ChildDepartments = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the head of this department
        /// </summary>
        public virtual User HeadUser
        {
            get { return _HeadUser; }
            set
            {
                if (value != null || value != _HeadUser) _HeadUser = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the vice-head of this department
        /// </summary>
        public virtual User ViceUser
        {
            get { return _ViceUser; }
            set
            {
                if (value != null || value != _ViceUser) _ViceUser = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region FOREIGN KEYS

        /// <summary>
        /// Get or set the super department of this department
        /// </summary>
        public int ParentDepartmentId { get; set; }

        /// <summary>
        /// Get or set the Id of this department's head user
        /// </summary>
        public int HeadUserId { get; set; }

        /// <summary>
        /// Get or set the Id of this department's vice head user
        /// </summary>
        public int ViceHeadUserId { get; set; }
        #endregion
    }
}
