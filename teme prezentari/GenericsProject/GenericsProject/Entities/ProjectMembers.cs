using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject.Entities
{
    internal class ProjectMembers : BaseEntity
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
    }
}
