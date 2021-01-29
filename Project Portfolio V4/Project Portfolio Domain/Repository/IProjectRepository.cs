using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_Portfolio_Domain.Model.Project;
using Project_Portfolio_Domain.Repository.Abstract;

namespace Project_Portfolio_Domain.Repository
{
    public interface IProjectRepository : IRepository<Project>
    {
        IQueryable<Project> GetFeatured();
    }
}
