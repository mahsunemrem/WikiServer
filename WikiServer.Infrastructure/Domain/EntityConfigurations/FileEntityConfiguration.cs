using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = WikiServer.Domain.AggregateModels.FileModels.File;

namespace WikiServer.Infrastructure.Domain.EntityConfigurations
{
    internal class FileEntityConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            throw new NotImplementedException();
        }
    }
}
