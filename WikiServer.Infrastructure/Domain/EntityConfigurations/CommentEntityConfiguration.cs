using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WikiServer.Domain.AggregateModels.CommentModels;

namespace WikiServer.Infrastructure.Domain.EntityConfigurations
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            throw new NotImplementedException();
        }
    }
}
