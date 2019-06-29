using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public abstract class EntityType : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method
        /// </summary>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private Guid _Guid;
        private int _Id;
        private DateTime? _TimeOfCreation;
        private DateTime? _TimeOfLastModification;
        private byte[] _TimeStamp;
        private int? _ModifiedByUserId;
        private int? _CreatedByUserId;
        private string _Custom1;
        private string _Custom2;
        private string _Custom3;

        /// <summary>
        /// Get or set the unique guid of this entity.
        /// </summary>
        public Guid Guid
        {
            get { return _Guid; }
            set
            {
                if (value != null || value != _Guid) _Guid = value;
                OnPropertyChanged("Guid");
            }
        }

        /// <summary>
        /// Get or set the id of this entity.
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set
            {
                if (value != _Id) _Id = value;
                OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Get or set the DateTime at which this entity was created.
        /// </summary>
        public DateTime? TimeOfCreation
        {
            get { return _TimeOfCreation; }
            set
            {
                if (value != null || value != _TimeOfCreation) _TimeOfCreation = value;
                OnPropertyChanged("TimeOfCreation");
            }
        }

        /// <summary>
        /// Get or set the DateTime at which this entity was last modified.
        /// </summary>
        public DateTime? TimeOfLastModification
        {
            get { return _TimeOfLastModification; }
            set
            {
                if (value != null || value != _TimeOfLastModification) _TimeOfLastModification = value;
                OnPropertyChanged("TimeOfLastModification");
            }
        }

        /// <summary>
        /// The rowversion of this entity.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion
        {
            get { return _TimeStamp; }
            set
            {
                if (value != null || value != _TimeStamp) _TimeStamp = value;
                OnPropertyChanged("RowVersion");
            }
        }

        /// <summary>
        /// The ID of the user modified this entity.
        /// </summary>
        public int? ModifiedByUserId
        {
            get { return _ModifiedByUserId; }
            set
            {
                if (value != _ModifiedByUserId) _ModifiedByUserId = value;
                OnPropertyChanged("ModifiedByUserId");
            }
        }

        /// <summary>
        /// The ID of the user created this entity
        /// </summary>
        public int? CreatedByUserId
        {
            get { return _CreatedByUserId; }
            set
            {
                if (value != _CreatedByUserId) _CreatedByUserId = value;
                OnPropertyChanged("CreatedByUserId");
            }
        }

        /// <summary>
        /// Get or set a custom string
        /// </summary>
        public string Custom1
        {
            get { return _Custom1; }
            set
            {
                if (value != null || value != _Custom1) _Custom1 = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set a custom string
        /// </summary>
        public string Custom2
        {
            get { return _Custom2; }
            set
            {
                if (value != null || value != _Custom2) _Custom2 = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set a custom string
        /// </summary>
        public string Custom3
        {
            get { return _Custom3; }
            set
            {
                if (value != null || value != _Custom3) _Custom3 = value;
                OnPropertyChanged();
            }
        }

        #region VIRTUAL PROPERTIES

        public virtual User CreatedByUser { get; set; }
        public virtual User ModifiedByUser { get; set; }

        #endregion

        #region METHODS

        public override string ToString()
        {
            string toString = "TYPE: " + this.GetType().ToString();
            toString += "\n";
            toString += ("GUID: " + this.Guid.ToString());
            return base.ToString(); 
        }

        #endregion
    }
}
