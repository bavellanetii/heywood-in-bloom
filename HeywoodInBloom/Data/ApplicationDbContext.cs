using HeywoodInBloom.Models;
using Microsoft.EntityFrameworkCore;

namespace HeywoodInBloom.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
