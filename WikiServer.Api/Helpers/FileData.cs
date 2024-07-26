using WikiServer.Api.Models;

namespace WikiServer.Api.Helpers
{
    public static class FileData
    {
        public static List<FileDTO> List = new List<FileDTO>
        {
            new FileDTO
            {
                Id = 1,
                Name = "Technical Document 1",
                Content = @"<h1>Welcome to Our Website</h1>
    
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam quis ligula et lorem cursus mollis. Vivamus non efficitur mauris. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce in ipsum vitae nisl aliquet tincidunt. Aliquam erat volutpat. Integer consectetur quam ac urna pretium, at malesuada risus gravida.</p>
    
    <p>Donec euismod, nisi at facilisis dapibus, eros lorem fermentum erat, a convallis sapien nunc ac libero. Cras interdum, sapien ut euismod posuere, lorem justo interdum augue, at auctor purus lacus vel purus. Nulla facilisi. In at lorem a elit tincidunt ultricies. Sed pretium quam ut urna bibendum, vel euismod dui vehicula. Vivamus auctor, est nec consequat tempor, dolor mauris auctor est, non cursus erat metus nec neque. Maecenas volutpat orci vitae nulla tincidunt, nec dictum turpis eleifend.</p>
    
    <p>Curabitur ac diam ut lectus tincidunt facilisis. In hac habitasse platea dictumst. Vestibulum luctus nulla non arcu feugiat, sit amet facilisis mi elementum. Nullam vehicula dui in felis aliquet, a venenatis neque hendrerit. Morbi posuere metus vel eros facilisis, sed aliquet erat congue. Vivamus fringilla sem at nisi pretium, nec suscipit velit lacinia. Suspendisse potenti. Duis et malesuada velit. Nunc bibendum massa ac ligula tempor, sed aliquam risus consectetur.</p>
    
    <p>Phasellus consectetur orci sit amet nisi cursus, sed tincidunt odio ultricies. Aliquam erat volutpat. Aenean tincidunt lacus ut eros condimentum, at interdum leo faucibus. Aenean dapibus ante et velit fermentum, non tempus elit fermentum. In scelerisque urna eget malesuada tincidunt. Proin tristique auctor nulla vel efficitur. Sed pulvinar, libero ac bibendum imperdiet, urna mi suscipit odio, non bibendum justo nisl a lorem. Etiam suscipit bibendum libero, et fermentum lacus pellentesque sit amet.</p>",
                FolderId = 1,
            },
            new FileDTO
            {
                Id = 2,
                Name = "Technical Document 2",
                Content = "<h1> file 2</h1>",
                FolderId = 1,
            },
            new FileDTO
            {
                Id = 3,
                Name = "Technical Document 3",
                Content = "<h1> file 3</h1>",
                FolderId = 2,
            },
            new FileDTO
            {
                Id = 4,
                Name = "Technical Document 4",
                Content = "<h1> file 4</h1>",
                FolderId = 2,
            },
            new FileDTO
            {
                Id = 5,
                Name = "Technical Document 5",
                Content = "<h1> file 5</h1>",
                FolderId = 4,
            }
        };
    }
}
