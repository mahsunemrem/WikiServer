using WikiServer.Domain.SeedWorks;

namespace WikiServer.Domain.AggregateModels.CommentModels
{
    public class Comment : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; }
        public required string Content { get;  set; }
        public required string AuthorName { get;  set; }
        public DateTime CreateDate { get;  set; } = DateTime.Now;
        public FileModels.File File { get; set; }
        public int FileID { get; set; }
        public string Reactions { get; set; } 
            
    }
    }
