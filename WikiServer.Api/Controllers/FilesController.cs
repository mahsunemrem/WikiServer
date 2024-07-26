﻿using Microsoft.AspNetCore.Mvc;
using WikiServer.Api.Helpers;

namespace WikiServer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(FileData.List);
        }

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
    }
}
