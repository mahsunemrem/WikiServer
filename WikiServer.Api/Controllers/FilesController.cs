using Microsoft.AspNetCore.Mvc;
using WikiServer.Api.Models;

namespace WikiServer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<FileDTO>
            {
                new FileDTO
                {
                    Id = 1,
                    FolderId =1,
                    Content = "test",
                    Name = "A"
                }
            });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new List<FileDTO>
            {
                new FileDTO
                {
                    Id = 1,
                    FolderId =1,
                    Content = "test",
                    Name = "A"
                }
            });
        }
    }
}
