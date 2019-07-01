using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class Tag : EntityType
    {
        private string _Content;
        private string _ColorCode;

        /// <summary>
        /// Get or set the content of this tag
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
        /// Get or set the Color of this tag
        /// </summary>
        public string ColorCode
        {
            get { return _ColorCode; }
            set
            {
                if (value != null || value != _ColorCode) _ColorCode = value;
                OnPropertyChanged();
            }
        }
    }
}
