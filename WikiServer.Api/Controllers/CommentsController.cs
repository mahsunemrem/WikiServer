using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WikiServer.Api.Helpers;
using WikiServer.Api.Models;

namespace WikiServer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListComment()
        {
            var values = CommentData.List.ToArray();
            return Ok(values);
            //   return Ok(CommentData.List);
        }


        [HttpPost]
        public IActionResult AddComment()
        {
            var comment = new CommentDTO
            {
                AuthorName = "Deneme",
                Content = "deneme2",
                CreateDate = DateTime.Now,
                FileId = 2,
                Id = 3
            };
            CommentData.List.Add(comment);
            return Ok(comment);
        }

        [HttpGet("{id}")]
        public IActionResult GetCommentUserById(int id)
        {
            var comment = CommentData.List.FirstOrDefault(x => x.Id == id);
            if (comment == null)
            {
                return BadRequest();
            }
            return Ok(comment);
        }
        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var comment = CommentData.List.FirstOrDefault(x => x.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            CommentData.List.Remove(comment);
            return Ok();
        }
        [HttpGet("~/api/files/{fileId}/comments")]
        public IActionResult GetCommentsByFileId(int fileId)
        {
            var comments = CommentData.List
                .Where(c => c.FileId == fileId)
                .ToArray();
            return Ok(comments);
        }
    }
}
/*~/ api / folders /{ folderId}/ [controller*  asd/