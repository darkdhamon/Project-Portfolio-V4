using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_Portfolio_Domain.Model.Project;
using Project_Portfolio_Domain.Repository;

namespace Project_Portfolio_V4._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public IProjectRepository ProjectRepository { get; }

        public ProjectController(IProjectRepository projectRepository)
        {
            ProjectRepository = projectRepository;
        }

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return ProjectRepository.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Project Get(int id)
        {
            return ProjectRepository.Get(id);
        }

        [HttpGet]
        [Route("Featured")]
        public IEnumerable<Project> Featured()
        {
            return ProjectRepository.GetFeatured();
        }
    }
}
