namespace WikiServer.Api.Models
{
    public class FolderDTO
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
    }
}
