using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTypes.Enums;
using CoreTypes.Enums.Sort;

namespace CoreTypes
{
    public class BoardColumn : EntityType
    {
        private string _Name;
        private string _ColorCode;
        private Board _Board;
        private int _BoardId;
        private ICollection<Project> _Projects;
        private int _DisplayIndex;
        private SortBy _SortBy;
        private SortDirection _SortDirection;
        private Status _Status;

        /// <summary>
        /// Get or set the column name
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
        /// Get or set the column color
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
        /// Get or set the board this column belong to
        /// </summary>
        public virtual Board Board
        {
            get { return _Board; }
            set
            {
                if (value != null || value != _Board) _Board = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of this column's board
        /// </summary>
        public int BoardId
        {
            get { return _BoardId; }
            set
            {
                if ( value != _BoardId) _BoardId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or Set the display index of this column in the board
        /// </summary>
        public int DisplayIndex
        {
            get { return _DisplayIndex; }
            set
            {
                if (value != _DisplayIndex) _DisplayIndex = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the projects in this column
        /// </summary>
        public virtual ICollection<Project> Projects
        {
            get { return _Projects; }
            set
            {
                if (value != null || value != _Projects) _Projects = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set how to sort projects
        /// </summary>
        public SortBy SortBy
        {
            get { return _SortBy; }
            set
            {
                if (value != _SortBy) _SortBy = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set sort direction
        /// </summary>
        public SortDirection SortDirection
        {
            get { return _SortDirection; }
            set
            {
                if (value != _SortDirection) _SortDirection = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the status of this Column
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

        public BoardColumn()
        {
            this.Projects = new ObservableCollection<Project>();
            this.SortBy = SortBy.EndDate;
            this.SortDirection = SortDirection.Ascending;
            this.Status = Status.Actived;
        }
    }
}
