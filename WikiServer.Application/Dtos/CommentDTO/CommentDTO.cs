using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiServer.Application.Dtos.CommentDTO
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public required string Content { get; set; }
        public required string AuthorName { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Reactions { get; set; }
      
    }
}
