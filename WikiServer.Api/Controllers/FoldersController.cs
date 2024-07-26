using Microsoft.AspNetCore.Mvc;
using WikiServer.Api.Helpers;

namespace WikiServer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoldersController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(FolderData.List);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var file = FolderData.List.FirstOrDefault(x => x.Id == id);
            if (file == null)
            {
                return BadRequest();
            }

            return Ok(file);
        }
    }
}
