using System;
using System.Collections.Generic;
using System.Text;
using Project_Portfolio_Domain.Repository.Abstract;

namespace Project_Portfolio_Domain.Model.Project
{
    public class Project: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DemoUrl { get; set; }
        public string SourceUrl { get; set; }
        public bool Featured { get; set; }
        public bool Show { get; set; }
        public List<Technology> Technologies { get; set; }

        public DateTime Updated { get; set; }
    }
}
