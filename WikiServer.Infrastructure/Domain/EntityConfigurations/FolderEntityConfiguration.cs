using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WikiServer.Domain.AggregateModels.FolderModels;

namespace WikiServer.Infrastructure.Domain.EntityConfigurations
{
    public class FolderEntityConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            builder.ToTable("Folders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(30).IsRequired();

        }
    }
}