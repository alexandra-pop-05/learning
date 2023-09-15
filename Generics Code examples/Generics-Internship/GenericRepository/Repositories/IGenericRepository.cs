using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public T GetById(int id);
        public List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
