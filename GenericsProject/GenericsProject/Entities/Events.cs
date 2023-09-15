using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject.Entities
{
    internal class Events : BaseEntity
    {
        public string EventName { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Description { get; set; }

    }
}
