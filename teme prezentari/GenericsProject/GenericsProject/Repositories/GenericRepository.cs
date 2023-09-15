using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsProject.Entities;

namespace GenericsProject.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private List<T> Entities;

        public GenericRepository(List<T> entities)
        {
            Entities = entities;
        }

        public void Delete(int id)
        {
            var existingEntityIdx = Entities.FindIndex(x => x.Id == id);

            if (existingEntityIdx < 0)
            {
                Console.WriteLine("Entity not found!");
            }

            Entities.RemoveAt(existingEntityIdx);
        }

        public List<T> GetAll()
        {
            return Entities;
        }

        public T GetById(int id)
        {
            return Entities.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            Entities.Add(entity);
        }

        public void Update(T entity)
        {
            var existingEntityIdx = Entities.FindIndex(x => x.Id == entity.Id);

            if (existingEntityIdx < 0)
            {
                Console.WriteLine("Entity not found!");
            }

            Entities[existingEntityIdx] = entity;
        }
    }
}

