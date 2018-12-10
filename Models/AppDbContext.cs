using System; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Final.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Project> Project { get; set; }
        // public DbSet<ProjectRoster> ProjectRoster { get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Project>().ToTable("Project");


            //Many to Many relationships
            //https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration

            //establish the join through the keys
            modelBuilder.Entity<ProjectTeam>()
                .HasKey(pr => new {pr.ProjectTeamID, pr.ProjectMembers});

            //set up the one to many map from Project to ProjectRoster
            modelBuilder.Entity<ProjectTeam>()
                .HasOne(pr => pr.Project)
                .WithMany(p => p.Members)
                .HasForeignKey(pr => pr.ProjectTeamID);

            //set up the one to many map from ProjectParticipant to ProjectRoster
            modelBuilder.Entity<ProjectTeam>()
                .HasOne(pr => pr.ProjectMembers)
                .WithMany(pp => pp.Project)
                .HasForeignKey(pr => pr.ProjectTeamID);

        }
    }
}