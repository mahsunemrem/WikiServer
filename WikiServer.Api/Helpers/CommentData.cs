using WikiServer.Api.Models;

namespace WikiServer.Api.Helpers
{
    public static class CommentData
    {
        public static List<CommentDTO> List = new List<CommentDTO>
        {
            new CommentDTO
            {
                Id = 1,
               AuthorName = "Yusuf Emrem",
               Content = "Deneme Yorumu",
               CreateDate = DateTime.Now,
               FileId = 1,
            },
             new CommentDTO
            {
                Id = 2,
               AuthorName = "Mahsun Emrem",
               Content = "Test Yorumu",
               CreateDate = DateTime.Now,
               FileId = 2,
            },
              new CommentDTO
            {
                Id = 3,
               AuthorName = "Ahmet Emrem",
               Content = "Test Yorumu",
               CreateDate = DateTime.Now,
               FileId = 2,
            },
               new CommentDTO
            {
                Id =4,
               AuthorName = "Mehmet Emrem",
               Content = "Test Yorumu",
               CreateDate = DateTime.Now,
               FileId = 2,
            }
        };
    }
}
