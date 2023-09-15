using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeedAndMigrations.Models
{
    public class MyEvent
    {
        public int MyEventId { get; set; }
        public virtual string Name { get; set; }
        //public virtual string? Description { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
