using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = WikiServer.Domain.AggregateModels.FileModels.File;

namespace WikiServer.Infrastructure.Domain.EntityConfigurations
{
    internal class FileEntityConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.ToTable("Files");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(100) 
                .IsRequired();

            builder.Property(x => x.Content)
                .IsRequired();

            builder.HasOne(x => x.Folder)
                .WithMany() 
                .HasForeignKey(x => x.FolderID);
        }
    }
}
