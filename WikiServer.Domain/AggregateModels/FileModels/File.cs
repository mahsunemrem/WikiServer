using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Domain.SeedWorks;

namespace WikiServer.Domain.AggregateModels.FileModels
{
    public class File : BaseEntity, IAggregateRoot
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Content { get; private set; }
        public Folder Folder { get; private set; }
        public int FolderID { get; set; }
        public bool IsPinned { get; set; }
        public File(string name, string content)
        {
            //    if(string.IsNullOrEmpty(name) && name.Length > 200)
            //{
            //    throw new BusinessRuleValidationException("Dosya adı 200 karakterden büyük olamaz");
           

                Name = name;
            Content = content;
        }
   
    }
}
