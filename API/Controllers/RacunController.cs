using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.Dtos;
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

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("FilterRacuni")]
        public async Task<ActionResult<List<RacunDto>>> FilterRacuni([FromServices] IRacunService racunService)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await racunService.FilterRacuni();
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Problem sa filtriranjem racuna");
                return Problem(statusCode: 500);
            }
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("GetRacun")]
        public async Task<ActionResult<RacunDto>> GetRacun(int id, [FromServices] IRacunService racunService)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await racunService.GetRacun(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Problem sa dobavljanjem racuna");
                return Problem(statusCode: 500);
            }
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


 /// <summary>
        /// Delete Racun
        /// </summary>
        /// <param name="id"></param>
        /// <param name="racunService"></param>
        /// <returns></returns>
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [HttpPost("Delete/{id:int}")]
        public async Task<ActionResult<bool>> Delete(int id,
            [FromServices] IRacunService racunService)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Error");
                }

                var result = await racunService.DeleteAsync(id);
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
