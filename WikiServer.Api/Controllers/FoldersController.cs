using Microsoft.AspNetCore.Mvc;
using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Dtos.FolderDTO;
using WikiServer.Infrastructure.Domain;

namespace WikiServer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoldersController : Controller
    {
        private readonly IFolderModelService _modelService;

        public FoldersController(IFolderModelService modelService)
        {
            _modelService = modelService;
        }
        [HttpPost]
        public IActionResult CreateFolder([FromBody] FolderDTO folderDTO)
        {

            try
            {
                _modelService.AddOrUpdate(folderDTO);
                var successResult = Result.SuccessResult("Klasör başarılı bir şekilde oluşturuldu.");
                return Ok(successResult);
            }

            catch (Exception ex)
            {
                var errorResult = Result.FailureResult("Klasör oluşturulamadı.", new List<string> { ex.Message });
                return StatusCode(500, errorResult);
            }

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _modelService.GetAllFolder();
            return Ok(result);
        }

        //    return Ok(file);
        //}
    }
}
