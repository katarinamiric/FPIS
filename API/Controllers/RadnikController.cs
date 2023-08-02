using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.Dtos;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RadnikController : ControllerBase
    {
            private readonly ILogger<RadnikController> _logger;
            public RadnikController(ILogger<RadnikController> logger)
            {
                _logger = logger;
            }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("GetRadnici")]
        public async Task<ActionResult<List<RadnikDto>>> GetRadnici([FromServices] IRadnikService radnikService)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await radnikService.GetRadnici();
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Problem");
                return Problem(statusCode: 500);
            }
        }
    }
}