using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTypes.Enums;

namespace CoreTypes
{
    public class Board : EntityType
    {
        private string _Name;
        private string _Description;
        private string _ColorCode;
        private int _DisplayIndex;
        private User _User;
        private int _UserId;
        private ICollection<BoardColumn> _BoardColumns;
        private Status _Status;

        /// <summary>
        /// Get or set the name of this board.
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
        /// Get or set the description of this board.
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
        /// Get or set the ColorCode of this board
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
        /// Get or Set the display index of this board in the portfolio
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
        /// Get or set the user this board belong to
        /// </summary>
        public virtual User User
        {
            get { return _User; }
            set
            {
                if (value != null || value != _User) _User = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the id of the user
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set
            {
                if (value != _UserId) _UserId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the column collection of this board
        /// </summary>
        public virtual ICollection<BoardColumn> BoardColumns
        {
            get { return _BoardColumns; }
            set
            {
                if (value != null || value != _BoardColumns) _BoardColumns = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Get or set the status of this board
        /// </summary>
        public Status Status
        {
            get { return _Status; }
            set
            {
                if (value != _Status) _Status = value;
                OnPropertyChanged();
            }
        }



        public Board()
        {
            this.BoardColumns = new ObservableCollection<BoardColumn>();
            this.Status = Status.Actived;
        }
    }
}
