using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsProject.Entities;

namespace GenericsProject.Repositories
{
    internal interface IGenericRepository<T> where T : BaseEntity
    {
        public T GetById(int id);
        public List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
