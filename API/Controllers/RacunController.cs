using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.Requests;
using API.Interfaces;
using API.Responses;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RacunController : ControllerBase
    {
        private readonly ILogger<RacunController> _logger;
        public RacunController(ILogger<RacunController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Add")]
        public async Task<ActionResult<bool>> AddRacun([FromBody] RacunRequestDto request,
           [FromServices] IRacunService racunService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = racunService.AddRacun(request);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Problem();
            }
        }

        [HttpPost("Update")]
        public async Task<ActionResult<bool>> UpdateRacun(int id, [FromBody] RacunRequestDto request,
            [FromServices] IRacunService racunService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await racunService.UpdateRacun(id, request);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Problem();
            }

        }
    }
}