using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTypes.Enums;

namespace CoreTypes
{
    public class Task : EntityType  
    {
        private string _Content;
        private ICollection<User> _AssignedUsers;
        private DateTime? _StartDate;
        private DateTime? _EndDate;
        private string _Description;
        private ICollection<File> _Files;
        private ICollection<User> _VisibleToUser;
        private TimeSpan? _ETA;
        private int _ProgressPecentage;
        private Status _Status;
        private ICollection<User> _NotifyUsers;
        private ICollection<Task> _DependOnTasks;
        private ICollection<Task> _DependTasks;
        private ICollection<Reminder> _Reminders;
        private TaskList _TaskList;
        private int? _TaskListId;
        private TaskListTemplate _TaskListTemplate;
        private int? _TaskListTemplateId;

        /// <summary>
        /// Get or set the content of this task
        /// </summary>
        public string Content
        {
            get { return _Content; }
            set
            {
                if (value != null || value != _Content) _Content = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the users who shoud do this task
        /// </summary>
        public virtual ICollection<User> AssignedUsers
        {
            get { return _AssignedUsers; }
            set
            {
                if (value != null || value != _AssignedUsers) _AssignedUsers = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the date this task shoud be started
        /// </summary>
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set
            {
                if (value != null || value != _StartDate) _StartDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the date this task shoud be finished.
        /// </summary>
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set
            {
                if (value != null || value != _EndDate) _EndDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the detail description for this task
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
        /// Get or set the file collection attached to this task.
        /// </summary>
        public ICollection<File> Files
        {
            get { return _Files; }
            set
            {
                if (value != null || value != _Files) _Files = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// This task will be hidden to these user.
        /// </summary>
        public ICollection<User> HiddenToUsers
        {
            get { return _VisibleToUser; }
            set
            {
                if (value != null || value != _VisibleToUser) _VisibleToUser = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the estimated time to complete this task
        /// </summary>
        public TimeSpan? ETA
        {
            get { return _ETA; }
            set
            {
                if (value != null || value != _ETA) _ETA = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the complete percent of this task.
        /// </summary>
        public int ProgressPecentage
        {
            get { return _ProgressPecentage; }
            set
            {
                if (value != _ProgressPecentage) _ProgressPecentage = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the status of this task.
        /// </summary>
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
        /// Get or set the users who will be notify of changes in this task
        /// </summary>
        public virtual ICollection<User> NotifyUsers
        {
            get { return _NotifyUsers; }
            set
            {
                if (value != null || value != _NotifyUsers) _NotifyUsers = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the tasks on which this task depends.
        /// </summary>
        public virtual ICollection<Task> DependOnTasks
        {
            get { return _DependOnTasks; }
            set
            {
                if (value != null || value != _DependOnTasks) _DependOnTasks = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the tasks that depend on this task.
        /// </summary>
        public virtual ICollection<Task> DependTasks
        {
            get { return _DependTasks; }
            set
            {
                if (value != null || value != _DependTasks) _DependTasks = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the reminders collection of this task
        /// </summary>
        public virtual ICollection<Reminder> Reminders
        {
            get { return _Reminders; }
            set
            {
                if (value != null || value != _Reminders) _Reminders = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the tasklist this task belong to
        /// </summary>
        public virtual TaskList TaskList
        {
            get { return _TaskList; }
            set
            {
                if (value != null || value != _TaskList) _TaskList = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of this tasklist
        /// </summary>
        public int? TaskListId
        {
            get { return _TaskListId; }
            set
            {
                if (value != null || value != _TaskListId) _TaskListId = value;
                OnPropertyChanged();
            }
        }

        //Get or set the task template this task belong to
        public virtual TaskListTemplate TaskListTemplate
        {
            get { return _TaskListTemplate; }
            set
            {
                if (value != null || value != _TaskListTemplate) _TaskListTemplate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of this task's tasklisttemplate
        /// </summary>
        public int? TaskListTemplateId
        {
            get { return _TaskListTemplateId; }
            set
            {
                if (value != null || value != _TaskListTemplateId) _TaskListTemplateId = value;
                OnPropertyChanged();
            }
        }

        public Task()
        {
            this.AssignedUsers = new ObservableCollection<User>();
            this.HiddenToUsers = new ObservableCollection<User>();
            this.NotifyUsers = new ObservableCollection<User>();
            this.Files = new ObservableCollection<File>();
            this.DependOnTasks = new ObservableCollection<Task>();
            this.DependTasks = new ObservableCollection<Task>();
            this.Status = Status.Started;
        }
    }
}
