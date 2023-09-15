using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApi.Domain
{
    public class Repository : IRepository
    {

        private List<User> _users = new List<User>()
        {
            new User
            {
                Id = 1,
                Name = "Cosmin",
                Email = "cosmin@gmail.com"
            },
            new User
            {
                Id = 2,
                Name = "Daniel",
                Email = "daniel@gmail.com"
            },
            new User
            {
                Id = 3,
                Name = "Adi",
                Email = "adi@gmail.com"
            }
        };

        public void AddUser(User user)
        {
            if (user == null) throw new ArgumentNullException("user");
            if (user.Name == null) throw new ArgumentNullException("name");
            if (user.Email == null) throw new ArgumentNullException("email");

            user.Id = _users.Max(x => x.Id) +1;

            _users.Add(user);
        }

        public void DeleteUserById(int id)
        {
            if (id == 0) throw new ArgumentException("id");

            _users.RemoveAll(x => x.Id == id);
        }

        public User GetUserById(int id)
        {
            var user = _users.Where(u => u.Id == id).FirstOrDefault();

            if (user is null)
            {
                throw new ArgumentNullException("user");
            }

            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}
