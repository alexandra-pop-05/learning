using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsProject.Entities;

namespace GenericsProject.Repositories
{
    internal interface IUserRepository : IGenericRepository<Users>
    {
       /* public Users GetById(int id);
        public List<Users> GetAll();
        void Insert(Users user);
        void Update(Users user);
        void Delete(int id);*/
       public Users GetByNickname(string nickname);
    }
}
