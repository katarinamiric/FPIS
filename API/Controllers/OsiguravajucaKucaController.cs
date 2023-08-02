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
    public class OsiguravajucaKucaController : ControllerBase
    {
         private readonly ILogger<OsiguravajucaKucaController> _logger;
        public OsiguravajucaKucaController(ILogger<OsiguravajucaKucaController> logger)
        {
            _logger = logger;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("GetOsiguravajuceKuce")]
        public async Task<ActionResult<List<OsiguravajucaKucaDto>>> GetOsiguravajuceKuce([FromServices] IOsiguravajucaKucaService osiguravajucaKucaService)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await osiguravajucaKucaService.GetOsiguravajuceKuce();
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