using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WikiServer.Api.ModelServices;
using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Dtos.FileDTO;

namespace WikiServer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        private readonly IFileModelService _fileModelService;

        public FilesController(IFileModelService fileModelService)
        {
            _fileModelService = fileModelService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var file = await _fileModelService.GetById(id);
            if (file == null)
            {
                return BadRequest();
            }

            return Ok(file);
        }

        [HttpGet("~/api/folders/{folderId}/[controller]")]
        public async Task<IActionResult> GetByFolderId(int folderId)
        {
            var files = await _fileModelService.GetByFolderId(folderId);

            return Ok(files);
        }


        [HttpPost]
        public async Task<IActionResult> AddFile(FileDTO file)
        {

            await _fileModelService.AddAsync(file);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> FileDelete(int id)
        {
            var file = await _fileModelService.GetById(id);
            if (file == null)
            {
                return NotFound(new { Message = "Dosya bulunamadı" });
            }

            await _fileModelService.Delete(id);
            return Ok(new { Message = "Dosya başarıyla silindi" });
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFile(FileDTO updatedFile)
        {
 
            var existingFile = await _fileModelService.GetById(updatedFile.Id);

            if (existingFile == null)
            {
                return NotFound(new { Message = "Güncellenecek dosya bulunamadı." });
            }
            
          await   _fileModelService.Update(updatedFile);

            return Ok(new { Message = "Dosya başarıyla güncellendi." });
        }
        [HttpPut("pin/{id}")]
        public async Task<IActionResult> PinFile(int id, [FromBody] bool isPinned)
        {
            var file = await _fileModelService.GetById(id);
            if (file == null)
            {
                return NotFound(new { Message = "Dosya bulunamadı." });
            }

            file.IsPinned = true;
            await _fileModelService.Update(file);

            return Ok(new { Message = isPinned ? "Dosya sabitlendi." : "Sabitlenme kaldırıldı." });
        }

    }

}

