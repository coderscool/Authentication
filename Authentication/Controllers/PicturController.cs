using Authentication.Application.Catalog;
using Authentication.Application.Catalog.Dtos.Pictur;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PicturController : ControllerBase
    {
        private readonly IPicturService _picturService;
        public PicturController(IPicturService picturService)
        {
            _picturService = picturService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var picturs = await _picturService.GetAll();
            return Ok(picturs);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PicturCreateRequest resquest)
        {
            var result = await _picturService.Create(resquest);
            if (result == 0)
                return BadRequest();

            var pictur = await _picturService.GetById(result);

            return CreatedAtAction(nameof(GetById), new { PicturId = result }, pictur);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int PicturId)
        {
            var picturs = await _picturService.GetById(PicturId);
            if (picturs == null)
                return BadRequest();
            return Ok(picturs);
        }
    }
}
