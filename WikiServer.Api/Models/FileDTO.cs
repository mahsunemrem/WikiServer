namespace WikiServer.Api.Models
{
    public class FileDTO
    {
        public int Id { get; set; }
        public int FolderId { get; set; }

        public string Name { get; set; }
        public string Content { get; set; }
    }
}
