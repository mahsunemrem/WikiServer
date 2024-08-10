using Microsoft.EntityFrameworkCore;

using WikiServer.Domain.AggregateModels.CommentModels;
using WikiServer.Domain.AggregateModels.FolderModels;
using File = WikiServer.Domain.AggregateModels.FileModels.File;

namespace WikiServer.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Folder> Customers { get; set; }
        public DbSet<File> Products { get; set; }
        public DbSet<Comment> OutboxMessages { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
