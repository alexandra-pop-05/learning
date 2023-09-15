using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject.Entities
{
    internal class Users : BaseEntity
    {
        public string Nickname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        // private string Password { get; set; }

        public override string ToString()
        {
            return $"User ID: {Id}, Nickname: {Nickname}, Birthday: {Birthday.ToShortDateString()}";
        }
    }
}
