using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class TaskList: EntityType
    {
        private string _Name;
        private string _Note;
        private ICollection<User> _HiddenToUsers;
        private ICollection<Milestone> _Milestones;
        private ICollection<Task> _Tasks;
        private Project _Project;
        private int _ProjectId;

        /// <summary>
        /// Get or set this tasklist's name
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
        /// Get or set this tasklist's note
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
        /// Get or set the users who will not see this tasklist
        /// </summary>
        public virtual ICollection<User> HiddenToUsers
        {
            get { return _HiddenToUsers; }
            set
            {
                if (value != null || value != _HiddenToUsers) _HiddenToUsers = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the milestones of this tasks list
        /// </summary>
        public virtual ICollection<Milestone> Milestones
        {
            get { return _Milestones; }
            set
            {
                if (value != null || value != _Milestones) _Milestones = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the tasks belong to this list
        /// </summary>
        public virtual ICollection<Task> Tasks
        {
            get { return _Tasks; }
            set
            {
                if (value != null || value != _Tasks) _Tasks = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this tasklist's project
        /// </summary>
        public virtual Project Project
        {
            get { return _Project; }
            set
            {
                if (value != null || value != _Project) _Project = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this tasklist's project id
        /// </summary>
        public int ProjectId
        {
            get { return _ProjectId; }
            set
            {
                if (value != _ProjectId) _ProjectId = value;
                OnPropertyChanged();
            }
        }

        public TaskList()
        {
            this.Tasks = new ObservableCollection<Task>();
            this.Milestones = new ObservableCollection<Milestone>();
            this.HiddenToUsers = new ObservableCollection<User>();
        }
    }
}
