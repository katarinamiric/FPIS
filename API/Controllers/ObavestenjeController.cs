using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;
using API.Interfaces;
using API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ObavestenjeController : ControllerBase
    {
        private readonly ILogger<ObavestenjeController> _logger;
        public ObavestenjeController(ILogger<ObavestenjeController> logger)
        {
            _logger = logger;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("GetAllObavestenja")]
        public async Task<ActionResult<List<ObavestenjeOIzvrsenojUplatiOsiguranjaDto>>> GetAllObavestenja([FromServices] IObavestenjeOIzvrsenojUplatiService obavestenjeOIzvrsenojUplatiService)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await obavestenjeOIzvrsenojUplatiService.GetAllObavestenja();
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Problem sa filtriranjem uplatnica");
                return Problem(statusCode: 500);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ObavestenjeOIzvrsenojUplatiOsiguranjaDto>> Get(int id, [FromServices] IObavestenjeOIzvrsenojUplatiService obavestenjeOIzvrsenojUplatiService)
        {
            try
            {
                var obavestenje = await obavestenjeOIzvrsenojUplatiService.GetObavestenjeOIzvrsenojUplati(id);
                return Ok(obavestenje);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.Message);
                return Problem();
            }
        }

        [HttpPost("Add")]
        public async Task<ActionResult<bool>> AddObavestenje([FromBody] ObavestenjeRequestDto request,
            [FromServices] IObavestenjeOIzvrsenojUplatiService obavestenjeOIzvrsenojUplatiService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = obavestenjeOIzvrsenojUplatiService.AddObavestenje(request);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Problem();
            }

        }

        [HttpPost("Update")]
        public async Task<ActionResult<bool>> UpdateObavestenje(int id, [FromBody] ObavestenjeRequestDto request,
            [FromServices] IObavestenjeOIzvrsenojUplatiService obavestenjeOIzvrsenojUplatiService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await obavestenjeOIzvrsenojUplatiService.UpdateObavestenje(id, request);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Problem();
            }
        }

        /// <summary>
                /// Delete Obavestenje
                /// </summary>
                /// <param name="id"></param>
                /// <param name="obavestenjeService"></param>
                /// <returns></returns>
                [ProducesResponseType((int)HttpStatusCode.OK)]
                [ProducesResponseType((int)HttpStatusCode.BadRequest)]
                [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
                [HttpDelete("Delete/{id:int}")]
                public async Task<ActionResult<bool>> Delete(int id,
                    [FromServices] IObavestenjeOIzvrsenojUplatiService obavestenjeService)
                {
                    try
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest("Error");
                        }

                        var result = await obavestenjeService.DeleteAsync(id);
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
