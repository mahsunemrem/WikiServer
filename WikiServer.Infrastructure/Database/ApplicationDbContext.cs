using Microsoft.EntityFrameworkCore;
using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Domain.AggregateModels.FileModels;
using WikiServer.Infrastructure.Domain.EntityConfigurations;
using File = WikiServer.Domain.AggregateModels.FileModels.File;
using WikiServer.Domain.AggregateModels.CommentModels;
using Newtonsoft.Json;

namespace WikiServer.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FolderEntityConfiguration());
            base.OnModelCreating(modelBuilder);

  

        }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
