using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsProject.Entities;

namespace GenericsProject.Repositories
{
    internal class UserRepository : GenericRepository<Users>, IUserRepository
    {
        private List<Users> Users;



        public UserRepository(List<Users> entities) : base(entities)
        {
        }

        public Users? GetByNickname(string nickname)
        {
            //throw new NotImplementedException();
            return Users.FirstOrDefault(u=>u.Nickname == nickname);
        }




        /*private GenericRepository<Users> _genericRepository;
public UserRepository() {
  // Users = Data.Users; 
  _genericRepository = new GenericRepository<Users>(Data.Users);
}*/

        /*public Users? GetById(int id) => Users.FirstOrDefault(u => u.Id == id);

        public List<Users> GetAll() => Users;

        public void Insert(Users user) {
            Users.Add(user);
        }

        public void Update(Users user)
        {
            var userIndex = Users.FindIndex(u=> u.Id == user.Id);

            if(userIndex == -1)
            {
                Console.WriteLine("User not found!");
            }

            Users[userIndex] = user;

        }*/

        /*
                public void Delete(int id)
                {
                    _genericRepository.Delete(id);
                }

                public Users GetById(int id)
                {
                    return _genericRepository.GetById(id);
                }

                public List<Users> GetAll()
                {
                    return _genericRepository.GetAll();
                }

                public void Insert(Users entity)
                {
                    _genericRepository.Insert(entity);
                }

                public void Update(Users entity)
                {
                    _genericRepository.Update(entity);
                }*/


    }

}
