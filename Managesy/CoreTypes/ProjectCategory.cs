using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoreTypes
{
    public class ProjectCategory: EntityType
    {
        private string _Name;
        private string _ColorCode;
        private ProjectCategory _SuperCategory;
        private int? _SuperCategoryId;
        private ICollection<ProjectCategory> _SubCategories;

        /// <summary>
        /// Get or set the name of this Category
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
        /// Get or set the color of this Category
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

        /// <summary>
        /// Get or set the super category of this category
        /// </summary>
        public virtual ProjectCategory SuperCategory
        {
            get { return _SuperCategory; }
            set
            {
                if (value != null || value != _SuperCategory) _SuperCategory = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of this category's super cat
        /// </summary>
        public int? SuperCategoryId
        {
            get { return _SuperCategoryId; }
            set
            {
                if (value != _SuperCategoryId) _SuperCategoryId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set this category's subsidiaries
        /// </summary>
        public virtual ICollection<ProjectCategory> SubCategories
        {
            get { return _SubCategories; }
            set
            {
                if (value != null || value != _SubCategories) _SubCategories = value;
                OnPropertyChanged();
            }
        }

        public Guid? SuperCategoryGuid { get; set; }

        public ProjectCategory()
        {
            this.SubCategories = new ObservableCollection<ProjectCategory>();
        }
    }
}
