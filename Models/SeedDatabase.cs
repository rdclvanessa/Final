using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Final.Models
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {

                // CLIENTS
                if (context.Client.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var clients = new List<Client>
                {
                    new Client { FirstName="Jimmie", LastName="Ramos", CompanyName="ACME", Email="jramos@acme.com", Phone="555-555-5555" },
                    new Client { FirstName="Kristy", LastName="Miles", CompanyName="World Wide Industries", Email="kmiles@wwi.com", Phone="555-555-5555" },
                    new Client { FirstName="Shelley", LastName="Walker", CompanyName="Big Money Inc", Email="swalker@bigmoneyinc.com", Phone="555-555-5555" }
                };
                context.AddRange(clients);
                context.SaveChanges();


                // CLIENTS
                if (context.Member.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var members = new List<Member>
                {
                    new Member { FirstName="Mamie", LastName="Santiago", Major="CIS", Email="msantiago@buffs.wtamu.edu", Phone="555-555-5555" },
                    new Member { FirstName="Pete", LastName="Perez", Major="CIS", Email="pperez@buffs.wtamu.edu", Phone="555-555-5555" },
                    new Member { FirstName="Flora", LastName="Williamson", Major="CIS", Email="fwiliamson@buffs.wtamu.edu", Phone="555-555-5555" },
                    new Member { FirstName="Laverne", LastName="Wolfe", Major="CIS", Email="lwolfe@buffs.wtamu.edu", Phone="555-555-5555" },
                    new Member { FirstName="Delia", LastName="Bridges", Major="CIS", Email="dbridges@buffs.wtamu.edu", Phone="555-555-5555" },
                    new Member { FirstName="Rebecca", LastName="Morton", Major="CIS", Email="rmorton@buffs.wtamu.edu", Phone="555-555-5555" },
                    new Member { FirstName="Franklin", LastName="Arnold", Major="CIS", Email="farnold@buffs.wtamu.edu", Phone="555-555-5555" }
                };
                context.AddRange(members);
                context.SaveChanges();

                // PROJECTS
                if (context.Project.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var projects = new List<Project>
                {
                    new Project { ProjectName="The Big One", ProjectDescription="The One Project to rule them all" },
                    new Project { ProjectName="Awesome", ProjectDescription="This project is awesome" },
                    new Project { ProjectName="Easy Project", ProjectDescription="This project is so easy, it completes itself" }
                };
                context.AddRange(projects);
                context.SaveChanges();
            }
        }
    }
}