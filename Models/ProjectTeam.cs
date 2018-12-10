using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class ProjectTeam
    {
        public string ProjectTeamID { get; set; }
        public ProjectMembers ProjectMembers { get; set; }
       // public string ID { get; set; }
        public Project Project { get; set; }
    }
}