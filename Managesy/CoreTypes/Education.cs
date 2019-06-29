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


    }
}
