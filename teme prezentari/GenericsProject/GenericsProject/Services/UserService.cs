using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsProject.Entities;
using GenericsProject.Repositories;

namespace GenericsProject.Services
{
    internal class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<Users> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public Users GetUserByNickname(string nickname)
        {
            return _userRepository.GetByNickname(nickname);
        }

        public void AddUser(Users user)
        {
            _userRepository.Insert(user);
        }
        public void UpdateUser(Users user)
        {
            _userRepository.Update(user);
        }
        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
