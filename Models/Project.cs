using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class Project
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Project Name")]                
        public string ProjectName { get; set; }
        [Display(Name = "Project Description")]                
        public string ProjectDescription { get; set; }
        public ICollection<ProjectTeam> Members { get; set; }

        public override string ToString(){
            return $"Project Name: {this.ProjectName}\nProject Description: {this.ProjectDescription}";
        }
    }

}