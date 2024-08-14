using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
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

        [HttpPost]
        public IActionResult AddFile(FileDTO file)
        {
            file.Id = FileData.List.Count > 0 ? FileData.List.Max(c => c.Id) + 1 : 1;
            if (file.FolderId == 0 || file.FolderId == null)
            {
                return BadRequest();
            }
            FileData.List.Add(file);
            return Ok();
        }

        [HttpGet]
        public IActionResult FileList()
        {
            return Ok(FileData.List.ToList());
        }
        [HttpDelete("{id}")]
        public IActionResult FileDelete(int id)
        {
            var values = FileData.List.FirstOrDefault(x=> x.Id == id);
            
            return Ok(FileData.List.Remove(values));
        }
        [HttpPut("{id}")]
        public IActionResult UpdateFile(int id, FileDTO updatedFile)
        {
           
            var existingFile = FileData.List.FirstOrDefault(x => x.Id == id);
            if (existingFile == null)
            {
                return NotFound();
            }


            existingFile.Name = updatedFile.Name;
            existingFile.FolderId = updatedFile.FolderId;
            existingFile.Content = updatedFile.Content;

    

            return Ok(existingFile);
        }
    }
}
