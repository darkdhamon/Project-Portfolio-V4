using System;
using System.Collections.Generic;
using System.Linq;
using Project_Portfolio_Domain.Model.Project;
using Project_Portfolio_Domain.Repository;

namespace ProjectPortfolioDomain.MockDB
{
    public class ProjectMockRepo :IProjectRepository
    {
        private List<Project> _data;

        public IQueryable<Project> Data
        {
            get => (_data??=new List<Project>
            {
                new Project()
                {
                    Id = 1,
                    Name = "Project1",
                    Description = "Desc1",
                    Featured = true,
                    DemoUrl = "Demo1",
                    SourceUrl = "Source1",
                    Show = true,
                    Updated = DateTime.Now,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ImageDataUrl = "https://th.bing.com/th/id/Rab111ab1ee80003a8572de54c25df6bc?rik=fQoyieInqg6elg&riu=http%3a%2f%2fcliparts.co%2fcliparts%2fLTd%2f5aL%2fLTd5aLokc.jpg&ehk=WRC60g%2fJABi%2f9uE6%2bIFxie8ilohMIad%2fhHx9pNeEx5Q%3d&risl=&pid=ImgRaw",
                    ShortDescription = "I",
                    Tags = new List<Tag>
                    {
                        new Tag
                        {
                            Id = 1,
                            Name = "tech1"
                        }
                    }
                },
                new Project()
                {
                    Id = 2,
                    Name = "Project2",
                    Description = "Desc2",
                    Featured = false,
                    DemoUrl = "Demo2",
                    SourceUrl = "Source2",
                    Show = true,
                    Updated = DateTime.Now,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ImageDataUrl = "https://wallup.net/wp-content/uploads/2016/01/304025-nature-love-Love_Love_Life.jpg",
                    ShortDescription = "Love",
                    Tags = new List<Tag>
                    {
                        new Tag
                        {
                            Id = 1,
                            Name = "tech2"
                        }
                    }
                },
                new Project()
                {
                    Id = 3,
                    Name = "Project3",
                    Description = "Desc3",
                    Featured = true,
                    DemoUrl = "Demo3",
                    SourceUrl = "Source3",
                    Show = false,
                    Updated = DateTime.Now,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ImageDataUrl = "https://logos.textgiraffe.com/logos/logo-name/lucy-designstyle-jungle-m.png",
                    ShortDescription = "Lucy",
                    Tags = new List<Tag>
                    {
                        new Tag
                        {
                            Id = 1,
                            Name = "tech3"
                        }
                    }
                }
            }).AsQueryable();
        }

        public IQueryable<Project> GetAll()
        {
            return Data;
        }

        public Project Get(int entityId)
        {
            return Data.FirstOrDefault(project => project.Id == entityId);
        }

        public void AddOrUpdate(Project entity)
        {
            var replaced = Data.FirstOrDefault(project => project.Id == entity.Id);
            _data.Remove(replaced);
            _data.Add(entity);
        }

        public void Delete(int entityId)
        {
            var deleted = Data.FirstOrDefault(project => project.Id == entityId);
            _data.Remove(deleted);
        }

        public IQueryable<Project> GetFeatured()
        {
            return Data.Where(project => project.Featured);
        }
    }
}
