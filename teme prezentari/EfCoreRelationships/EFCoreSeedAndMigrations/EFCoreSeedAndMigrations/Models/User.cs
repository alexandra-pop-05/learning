using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSeedAndMigrations.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int MyEventId { get; set; }
        public MyEvent? Event { get; set; }
    }
}
