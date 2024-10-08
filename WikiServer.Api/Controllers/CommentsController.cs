﻿using Microsoft.AspNetCore.Mvc;
using WikiServer.Api.Helpers;
using WikiServer.Api.Models;

namespace WikiServer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListComment() => Ok(CommentData.List);

        [HttpPost]
        public IActionResult AddComment(CommentDTO comment)
        {

            comment.Id = CommentData.List.Count > 0 ? CommentData.List.Max(c => c.Id) + 1 : 1;

            CommentData.List.Add(comment);

            return Ok();
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
        [HttpDelete("{id}")]
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
        [HttpGet("~/api/files/{fileId}/[controller]")]
        public IActionResult GetCommentsByFileId(int fileId)
        {
            var comments = CommentData.List
                .Where(c => c.FileId == fileId)
                .ToArray();
            return Ok(comments);
        }
    }
}
