using EventAgency.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EventAgency.Dal
{
    public class EventAgencyContext : DbContext
    {
        #region DbSets

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<DocumentTemplate> DocumentTemplates { get; set; }
        public virtual DbSet<TemplateAttribute> TemplateAttributes { get; set; }
        public virtual DbSet<DocumentAttributeValue> DocumentAttributeValues { get; set; }

        #endregion DbSets

        private readonly IConfiguration Configuration;

        public EventAgencyContext(IConfiguration configuration)
        {
            Configuration = configuration; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.FundedProjects);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Manager)
                .WithMany(p => p.ManagedProjects);
        }
    }
}
