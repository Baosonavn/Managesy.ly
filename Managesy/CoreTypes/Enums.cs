using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    namespace Enums
    {
        public enum Status
        {
            Actived,
            InActived,
            Deleted
        }

        namespace User
        {
            /// <summary>
            /// Status of an user.
            /// </summary>
            public enum State
            {
                Invited,
                Inactived,
                Actived,
                Deactived,
                Deleted
            } 

            /// <summary>
            /// Gender of an user.
            /// </summary>
            public enum Gender
            {
                Male,
                Female,
                NotSet
            }

            /// <summary>
            /// Marital Status of an user
            /// </summary>
            public enum MaritalStatus
            {
                NotSet,
                Single,
                Married,
                Divorced
            }
        }
 
        namespace Company
        {
            public enum Type
            {
                Customer,
                User
            }
        }
    }
}
