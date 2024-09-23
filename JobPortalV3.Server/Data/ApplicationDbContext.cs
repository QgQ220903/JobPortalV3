using JobPortalV3.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortalV3.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<JobSeeker > JobSeekers { get; set; }
        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "HTML", Status = true },
                new Skill { Id = 2, Name = "CSS", Status = true }

                );
        }



    }
}
