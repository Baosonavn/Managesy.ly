using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class Reminder : EntityType 
    {
        private string _Message;
        private DateTime _SendTime;
        private ICollection<User> _SendToUsers;
        private Task _Task;
        private int _TaskId;
        private bool _IsRelativeToDueDate;
        private TimeSpan? _TimeRelatedToDueDate;

        /// <summary>
        /// Get or set the message to send to users
        /// </summary>
        public string Message
        {
            get { return _Message; }
            set
            {
                if (value != null || value != _Message) _Message = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the time that the reminder will be sent
        /// </summary>
        public DateTime SendTime
        {
            get { return _SendTime; }
            set
            {
                if (value != null || value != _SendTime) _SendTime = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the users who will receive this reminder.
        /// </summary>
        public ICollection<User> SendToUsers
        {
            get { return _SendToUsers; }
            set
            {
                if (value != null || value != _SendToUsers) _SendToUsers = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the task that this reminder is on
        /// </summary>
        public virtual Task Task
        {
            get { return _Task; }
            set
            {
                if (value != null || value != _Task) _Task = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of the task owns this reminder.
        /// </summary>
        public int TaskId
        {
            get { return _TaskId; }
            set
            {
                if (value != _TaskId) _TaskId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set whether this reminder is relative to task's due date.
        /// </summary>
        public bool IsRelativeToDueDate
        {
            get { return _IsRelativeToDueDate; }
            set
            {
                if (value != _IsRelativeToDueDate) _IsRelativeToDueDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the relative time span that this reminder's time related to task's due date
        /// </summary>
        public TimeSpan? TimeRelatedToDueDate
        {
            get { return _TimeRelatedToDueDate; }
            set
            {
                if (value != null || value != _TimeRelatedToDueDate) _TimeRelatedToDueDate = value;
                OnPropertyChanged();
            }
        }
      

        public Reminder()
        {
            this.SendToUsers = new ObservableCollection<User>();
        }
    }
}
