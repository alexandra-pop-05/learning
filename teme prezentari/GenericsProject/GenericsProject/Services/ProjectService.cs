using GenericsProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsProject.Entities;

namespace GenericsProject.Services
{
    internal class ProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public List<Project> GetAllProjects()
        {
            return _projectRepository.GetAll();
        }

        public void AddProject(Project project)
        {
            _projectRepository.Insert(project);
        }

        public void Delete(int id) {
            _projectRepository.Delete(id);
        }

        public Project GetById(int id)
        {
            return _projectRepository.GetById(id);
        }

        public void UpdateProject(Project project)
        {
            _projectRepository.Update(project);
        }

        public string GetProjectStatus(string name)
        {
            return _projectRepository.GetProjectStatus(name);
        }

    }
}
