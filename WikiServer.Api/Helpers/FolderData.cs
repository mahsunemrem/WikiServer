using WikiServer.Api.Models;

namespace WikiServer.Api.Helpers
{
    public static class FolderData
    {
        public static List<FolderDTO> List = new()
        {
            new FolderDTO
            {
                Id = 1,
                ParentId = null,
                Name = "A",
                Description = "Desc A"
            },
            new FolderDTO
            {
                Id = 2,
                ParentId = null,
                Name = "B",
                Description = "Desc B"
            },
            new FolderDTO
            {
                Id = 3,
                ParentId = 2,
                Name = "C",
                Description = "Desc C"
            },
            new FolderDTO
            {
                Id = 4,
                ParentId = 3,
                Name = "D",
                Description = "Desc D"
            },
            new FolderDTO
            {
                Id = 5,
                ParentId = 4,
                Name = "E",
                Description = "Desc E"
            },
            new FolderDTO
            {
                Id = 6,
                ParentId = 3,
                Name = "F",
                Description = "Desc F"
            }
        };
    }
}
