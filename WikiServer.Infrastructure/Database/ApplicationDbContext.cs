using Microsoft.EntityFrameworkCore;
using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Infrastructure.Domain.EntityConfigurations;

namespace WikiServer.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FolderEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Folder> Folders { get; set; }
    }
}
