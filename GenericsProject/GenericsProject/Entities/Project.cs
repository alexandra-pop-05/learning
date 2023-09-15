using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject.Entities
{
    internal class Project : BaseEntity
    {
        public string ProjectName { get; set; }
       /* public int TeamManagerId { get; set; }
        public int ProjectManagerId { get; set; }*/
        public string ProjectStatus { get; set; }
        /*public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }*/

        public override string ToString()
        {
            return $"Project ID: {Id}, Project name: {ProjectName}, Project status: {ProjectStatus}";
        }
    }
}
