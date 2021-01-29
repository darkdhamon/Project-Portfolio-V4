using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;
using Project_Portfolio_Domain.Repository.Abstract;

namespace Project_Portfolio_Domain.Model.Project
{
    public class Project: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [MaxLength(200)]
        public string ShortDescription { get; set; }
        public string DemoUrl { get; set; }
        public string SourceUrl { get; set; }
        public string ImageDataUrl { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Featured { get; set; }
        public bool Show { get; set; }
        public List<Tag> Tags { get; set; }

        public DateTime Updated { get; set; }
    }
}
