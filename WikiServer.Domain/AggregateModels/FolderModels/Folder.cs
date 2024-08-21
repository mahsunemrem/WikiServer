using WikiServer.Domain.SeedWorks;

namespace WikiServer.Domain.AggregateModels.FolderModels
{
    public class Folder : BaseEntity, IAggregateRoot
    {
        public int Id { get;  private set; }
        public int? ParentId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Folder(int? parentId, string name, string description)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessRuleValidationException("Klasör adı boş geçilemez!");
            }

            if (string.IsNullOrEmpty(name) && name.Length > 200)
            {
                throw new BusinessRuleValidationException("Klasör adı 200 karakterden büyük olamaz!");
            }

        
            ParentId = parentId;
            Name = name;
            Description = description;
        }
    }
}
