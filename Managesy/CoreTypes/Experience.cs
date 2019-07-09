using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class Experience: EntityType
    {
        private string _Organization;
        private string _Country;
        private string _Province;
        private string _WorkDescription;
        private string _From;
        private string _To;
        private bool _IsOnProgress;
        private string _ResignReason;

        /// <summary>
        /// Get or set the Organization name.
        /// </summary>
        public string Organization
        {
            get { return _Organization; }
            set
            {
                if (value != null || value != _Organization) _Organization = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the country of this experience
        /// </summary>
        public string Country
        {
            get { return _Country; }
            set
            {
                if (value != null || value != _Country) _Country = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the province of the country
        /// </summary>
        public string Province
        {
            get { return _Province; }
            set
            {
                if (value != null || value != _Province) _Province = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the Description of this experience record.
        /// </summary>
        public string WorkDescription
        {
            get { return _WorkDescription; }
            set
            {
                if (value != null || value != _WorkDescription) _WorkDescription = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the reason why the User quit this job
        /// </summary>
        public string ResignReason
        {
            get { return _ResignReason; }
            set
            {
                if (value != null || value != _ResignReason) _ResignReason = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the time when this experience begin
        /// </summary>
        public string From
        {
            get { return _From; }
            set
            {
                if (value != null || value != _From) _From = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the time when this experience ended.
        /// </summary>
        public string To
        {
            get { return _To; }
            set
            {
                if (value != null || value != _To) _To = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set if this is the current work
        /// </summary>
        public bool IsWorking
        {
            get { return _IsOnProgress; }
            set
            {
                if (value != _IsOnProgress) _IsOnProgress = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the user who has this record.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Get or set the id of the user who has this record
        /// </summary>
        public int UserId { get; set; }
        public Guid UserGuid { get; set; }
    }
}
