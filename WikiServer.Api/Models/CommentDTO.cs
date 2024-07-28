namespace WikiServer.Api.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public int FileId { get; set; }

        public required string Content { get; set; }
        public required string AuthorName { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
