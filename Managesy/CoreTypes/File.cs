using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTypes
{
    public class File : EntityType
    {
        //A file might be upload in a project page
        public virtual Project Project { get; set; }
        public int? ProjectId { get; set; }
        public Guid? ProjectGuid { get; set; }

        //or in a task
        public virtual Task Task { get; set; }
        public int? TaskId { get; set; }
        public Guid? TaskGuid { get; set; }

        //It should have a category

        public virtual TaskCategory TaskCategory { get; set;}




    }
}
