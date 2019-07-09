using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTypes.Enums.Education;

namespace CoreTypes
{
    public class Education: EntityType
    {
        private string _Institution;
        private Level _Level;
        private string _Country;
        private string _Province;
        private string _Major;
        private string _From;
        private string _To;
        private bool _IsOnProgress;

        /// <summary>
        /// Get or set the Inistitution name.
        /// </summary>
        public string Institution
        {
            get { return _Institution; }
            set
            {
                if (value != null || value != _Institution) _Institution = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the education degree level
        /// </summary>
        public Level Level
        {
            get { return _Level; }
            set
            {
                if (value != _Level) _Level = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the country of this education
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
        /// Get or set the major of this education record.
        /// </summary>
        public string Major
        {
            get { return _Major; }
            set
            {
                if (value != null || value != _Major) _Major = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the time when this education begin
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
        /// Get or set the time when this education ended.
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
        /// Get or set if this education is in progress
        /// </summary>
        public bool IsInProgress
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

        /// <summary>
        /// Get or set the guid of the user who has this record
        /// </summary>
        public Guid UserGuid { get; set; }
    }
}
