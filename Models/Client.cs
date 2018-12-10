using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class Client : ProjectMembers
    {
        [Key]
         public int ClientID { get; set; }
           [Display(Name = "Company Name")]        
        public string CompanyName {get; set;}

    }
       
}