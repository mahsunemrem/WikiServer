using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WikiServer.Api.ModelServices;
using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Dtos.CommentDTO;
using WikiServer.Domain.AggregateModels.FolderModels;

namespace WikiServer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentModelService _commentModelService;

        public CommentsController(ICommentModelService commentModelService)
        {
            _commentModelService = commentModelService;
        }

        [HttpGet]
        public async Task<IActionResult> ListComment()
        {
            var result = await _commentModelService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentDTO comment)
        {
            await _commentModelService.AddAsync(comment);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentUserById(int id)
        {
            var comment = await _commentModelService.GetAll();
            var commentUserId = comment.Where(c => c.Id == id).FirstOrDefault();

            return Ok(commentUserId);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _commentModelService.Delete(id);
            return Ok();
        }
        [HttpGet("~/api/files/{fileId}/[controller]")]
        public async Task<IActionResult> GetLimitedCommentsByFileId(int fileId, int limit = 3, int offset = 0)
        {
            var values = await _commentModelService.GetAll();
            var commentByFile = values.Where(c => c.FileId == fileId)
            .Skip(offset).Take(limit);

            return Ok(commentByFile);
        }
        [HttpGet("count/{fileId}")]
        public async Task<IActionResult> GetTotalCommentsCount(int fileId)
        {
            var values = await _commentModelService.GetAll();
            var commentByFile = values.Where(c => c.FileId == fileId).Count();
            return Ok(commentByFile);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCommentReactions(int id, [FromBody] string reactions)
        {
            var comment = await _commentModelService.GetById(id);
            if (comment == null)
            {
                return NotFound();
            }

            //   comment.Reactions = string.Join(",", reactions); // Reactions'ı string olarak saklıyoruz
            comment.Reactions = reactions; 

            await _commentModelService.AddAsync(comment);

            return Ok();
        }

    }
}
