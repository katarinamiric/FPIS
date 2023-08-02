using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.Dtos.Requests;
using API.Interfaces;
using API.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UplatnicaZaOsiguranjeController : ControllerBase
    {
        private readonly ILogger<UplatnicaZaOsiguranjeController> _logger;

        public UplatnicaZaOsiguranjeController(ILogger<UplatnicaZaOsiguranjeController> logger)
        {
            _logger = logger;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("FilterUplatnice")]
        public async Task<ActionResult<UplatnicaResponse>> FilterUplatnice([FromQuery] UplatnicaParameters parameters,
        [FromServices] IUplatnicaZaOsiguranjeService uplatnicaZaOsiguranjeService)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await uplatnicaZaOsiguranjeService.FilterUplatnice(parameters);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Problem sa filtriranjem uplatnica");
                return Problem(statusCode: 500);
            }
        }
    }
}