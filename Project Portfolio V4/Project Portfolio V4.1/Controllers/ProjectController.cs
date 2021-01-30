using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_Portfolio_Domain.Model.Project;
using Project_Portfolio_Domain.Repository;
using Project_Portfolio_Domain.ViewModels;

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
        [Route("page/{page}")]
        [Route("page/{page}/{numPerPage}")]
        public IEnumerable<ProjectCard> GetCards(int page, int numPerPage = 8)
        {
            page = page - 1;
            if (page < 0) page = 0;
            return ProjectRepository.GetAll().Skip(page * numPerPage).Take(numPerPage).Select(project=>new ProjectCard
            {
                Id = project.Id,
                Name = project.Name,
                ShortDescription = project.ShortDescription,
                DemoUrl = project.DemoUrl,
                SourceUrl = project.SourceUrl,
                ImageDataUrl = project.ImageDataUrl
            });
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
