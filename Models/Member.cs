
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class Member : ProjectMembers  
    {
        public int MemberID{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}

        public string Email{get;set;}

        public string Phone{get;set;}

        [Display(Name = "Major")]                
        public string Major {get; set;}
    }
}