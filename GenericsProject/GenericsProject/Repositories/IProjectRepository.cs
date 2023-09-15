using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsProject.Entities;

namespace GenericsProject.Repositories
{
    internal interface IProjectRepository : IGenericRepository<Project>
    {
        /*public Project GetById(int id);
        public List<Project> GetAll();
        void Insert(Project project);
        void Update(Project project);
        void Delete(int id);*/

        public string GetProjectStatus(string ProjectName);
    }
}
