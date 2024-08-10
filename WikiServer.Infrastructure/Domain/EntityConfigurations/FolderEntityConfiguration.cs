using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WikiServer.Domain.AggregateModels.FolderModels;

namespace WikiServer.Infrastructure.Domain.EntityConfigurations
{
    internal class FolderEntityConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            throw new NotImplementedException();
        }
    }
}
