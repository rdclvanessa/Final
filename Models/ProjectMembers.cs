using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

 namespace Final.Models
 {
    public class ProjectMembers
    {
        public int ClientID { get; set; }

        [Display(Name = "First Name")]                
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]                
        public string LastName { get; set; }

        [Display(Name = "Email Address")]                
        public string Email{ get; set; }

        [Display(Name = "Phone Number")]                
        public string Phone{ get; set; }
        public ICollection<ProjectTeam> Project {get; set;}

        public override string ToString(){
            return $"First Name: {this.FirstName} Last Name: {this.LastName}";
        }
    }
}