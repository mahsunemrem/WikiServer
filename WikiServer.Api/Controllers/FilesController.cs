using Microsoft.AspNetCore.Mvc;
using WikiServer.Api.Helpers;
using WikiServer.Api.Models;

namespace WikiServer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var file = FileData.List.FirstOrDefault(x => x.Id == id);
            if (file == null)
            {
                return BadRequest();
            }

            return Ok(file);
        }

        [HttpGet("~/api/folders/{folderId}/[controller]")]
        public IActionResult GetByFolderId(int folderId)
        {
            var files = FileData
                .List
                .Where(x => x.FolderId == folderId)
                .Select(x => new FileBasicDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                });

            return Ok(files);
        }
    }
}
