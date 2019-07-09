using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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
        private Guid? _CreatedByUserGuid;
        private Guid? _ModifiedByUserGuid;

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
        /// The Guid of the user modified this entity.
        /// </summary>
        public Guid? ModifiedByUserGuid
        {
            get { return this._ModifiedByUserGuid; }
            set
            {
                if (value != null || value != _ModifiedByUserGuid) _ModifiedByUserGuid = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The Guid of the user created this entity
        /// </summary>
        public Guid? CreatedByUserGuid
        {
            get { return _CreatedByUserGuid; }
            set
            {
                if (value != null || value != _CreatedByUserGuid) _CreatedByUserGuid = value;
                OnPropertyChanged();
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

        /// <summary>
        /// Overide toString method to write some more information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string toString = "TYPE: " + this.GetType().ToString();
            toString += "\n";
            toString += ("GUID: " + this.Guid.ToString());
            return base.ToString(); 
        }

        /// <summary>
        /// Swap value of "DisplayIndex" property of 2 entity instance
        /// </summary>
        /// <param name="entity_1"></param>
        /// <param name="entity_2"></param>
        /// <returns></returns>
        protected static bool SwapDisplay(EntityType entity_1, EntityType entity_2)
        {
            try
            {
                //If the type of 2 instance are different then do nothing
                if (!entity_1.GetType().Equals(entity_2.GetType()))
                    return false;

                //Check if the type of 2 instance have property DisplayIndex
                PropertyInfo propertyInfo = entity_1.GetType().GetProperty("DisplayIndex");
                if (propertyInfo == null)
                    return false;

                dynamic temp = propertyInfo.GetValue(entity_1);
                propertyInfo.SetValue(entity_1, propertyInfo.GetValue(entity_2));
                propertyInfo.SetValue(entity_2, temp);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion
    }
}
