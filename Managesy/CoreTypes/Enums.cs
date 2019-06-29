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

            [Flags]
            public enum Permission
            {
                IsAdmin = 1,
                AddProject = 2,
                AccessProjectTemplate = 4,
                ManagePeopleAndCompany = 8,
                ExecutiveAccessToAllProjects = 16,
                NoSpecialPermission = 32
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

        namespace Education
        {
            public enum Level
            {
                Bachelor, //Dai hoc
                Associate, //cao dang
                Master, //Thac si
                PhD, //Tien si
                Other
            }
        }

        namespace Project
        {
            [Flags]
            public enum Feature
            {
                Task = 1,
                Message = 2,
                Time = 4,
                Risks = 8,
                Billing = 16,
                Milestones = 32,
                Files = 64,
                Notebooks = 128,
                Links = 256,
                Comments = 512
            }

            public enum Status
            {
                NotStarted,
                Started,
                Postponed,
                Completed,
                Archived,
                Deleted,
            }
        }
    }
}
