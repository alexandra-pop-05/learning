using GenericsProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject.Repositories
{
    internal class ProjectRepository : IProjectRepository
    {
        private List<Project> _projects;
        private GenericRepository<Project> _genericRepository;

        public ProjectRepository()
        {
            _genericRepository = new GenericRepository<Project>(Data.Project);
        }
        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        public List<Project> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public Project GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public string GetProjectStatus(string name)
        {
            var project = _genericRepository.GetAll().FirstOrDefault(p => p.ProjectName == name);
            return project.ProjectStatus;

        }

        public void Insert(Project entity)
        {
             _genericRepository.Insert(entity);
        }

        public void Update(Project entity)
        {
            _genericRepository.Update(entity);
        }
    }
}
