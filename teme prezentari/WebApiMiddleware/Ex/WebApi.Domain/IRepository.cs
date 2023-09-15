namespace WebApi.Domain
{
    public interface IRepository
    {
         IEnumerable<User> GetUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void DeleteUserById(int id);
    }
}
