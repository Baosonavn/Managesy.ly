using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class TaskListTemplate: EntityType
    {
        private string _Name;
        private string _Note;
        private ICollection<User> _HiddenToUsers;
        private ICollection<Task> _Tasks;

        /// <summary>
        /// Get or set the name of this template
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
        /// Get or set the default note to any tasklist based on this template
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
        /// Get or set the users who will not be able to see and use this template
        /// </summary>
        public ICollection<User> HiddenToUsers
        {
            get { return _HiddenToUsers; }
            set
            {
                if (value != null || value != _HiddenToUsers) _HiddenToUsers = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the Tasks insite this tasklist template
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

        public TaskListTemplate()
        {
            this.HiddenToUsers = new ObservableCollection<User>();
            this.Tasks = new ObservableCollection<Task>();
        }
    }
}
