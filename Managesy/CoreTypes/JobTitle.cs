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
    public class JobTitle : EntityType
    {
        #region FIELDS
        private string _Name;
        private string _Description;
        private Status _Status;
        private int _DisplayIndex;
        #endregion

        public JobTitle()
        {
            this.Users = new ObservableCollection<User>();
            this.Status = Status.Actived;
        }

        #region REQUIRED PROPERTIES

        /// <summary>
        /// Get or set the name of this jobtitle.
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
        /// Status of this jobtitle
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

        /// <summary>
        /// Get or set this jobtitle's displayindex
        /// </summary>
        public int DisplayIndex
        {
            get { return _DisplayIndex; }
            set
            {
                if (value != _DisplayIndex) _DisplayIndex = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region OPTIONAL PROPERTIES

        /// <summary>
        /// Get or set the description of this jobtitle.
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

        #endregion

        #region METHODS

        /// <summary>
        /// Swap the display index of 2 jobtitles
        /// </summary>
        public static void SwapDisplay(ref JobTitle job1,ref JobTitle job2)
        {
            int temp = job1.DisplayIndex;
            job1.DisplayIndex = job2.DisplayIndex;
            job2.DisplayIndex = temp;
        }

        #endregion
    }
}
