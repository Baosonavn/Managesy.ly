using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTypes.Enums.Project;

namespace CoreTypes
{
    public class Project: EntityType
    {
        private string _Name;
        private string _Description;
        private Company _Company;
        private int _CompanyId;
        private ICollection<User> _Users;
        private User _Owner;
        private int _OwnerId;
        private Feature _Feature;
        private DateTime? _Start;
        private DateTime? _End;
        private Status _Status;
        private ProjectCategory _Category;
        private int _CategoryID;
        private ICollection<Tag> _Tags;
        private int _DisplayIndex;

        /// <summary>
        /// Get or set the name of the project
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
        /// Get or set the description of the project
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

        /// <summary>
        /// Get or set the Company of this project.
        /// </summary>
        public virtual Company Company
        {
            get { return _Company; }
            set
            {
                if (value != null || value != _Company) _Company = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The Id of this project's company
        /// </summary>
        public int CompanyId
        {
            get { return _CompanyId; }
            set
            {
                if ( value != _CompanyId) _CompanyId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the users assigned to this project.
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
        /// Get or set the owner of this project.
        /// </summary>
        public virtual User Owner
        {
            get { return _Owner; }
            set
            {
                if (value != null || value != _Owner) _Owner = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of this project's owner.
        /// </summary>
        public int OwnerId
        {
            get { return _OwnerId; }
            set
            {
                if (value != _OwnerId) _OwnerId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the feature of this project.
        /// </summary>
        public Feature Feature
        {
            get { return _Feature; }
            set
            {
                if (value != _Feature) _Feature = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the start date of this project.
        /// </summary>
        public DateTime? Start
        {
            get { return _Start; }
            set
            {
                if (value != null || value != _Start) _Start = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the end date of this project.
        /// </summary>
        public DateTime? End
        {
            get { return _End; }
            set
            {
                if (value != null || value != _End) _End = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the project status
        /// </summary>
        public Status Status
        {
            get { return _Status; }
            set
            {
                if (value != _Status) _Status = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the project category
        /// </summary>
        public ProjectCategory Category
        {
            get { return _Category; }
            set
            {
                if (value != null || value != _Category) _Category = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of this project's category 
        /// </summary>
        public int CategoryId
        {
            get { return _CategoryID; }
            set
            {
                if (value != _CategoryID) _CategoryID = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the tag collection of this project
        /// </summary>
        public virtual ICollection<Tag> Tags
        {
            get { return _Tags; }
            set
            {
                if (value != null || value != _Tags) _Tags = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the display index of this project in the board
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

        public Project()
        {
            this.Users = new ObservableCollection<User>();
            this.Tags = new ObservableCollection<Tag>();

            //Default: Enable all feature
            this.Feature = Feature.Files | Feature.Message | Feature.Milestones | Feature.Risks | Feature.Task | Feature.Time;
        }
    }
}
