using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Requests;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UgovorController : ControllerBase
    {
        private readonly ILogger<UgovorController> _logger;
        public UgovorController(ILogger<UgovorController> logger)
        {
            _logger = logger;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("FilterUgovor")]
        public async Task<ActionResult<List<UgovorDto>>> FilterUgovor([FromQuery] UgovorParameters parameters,
        [FromServices] IUgovorService ugovorService)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }

            try
            {
                var result = await ugovorService.FilterUgovori(parameters);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Problem sa filtriranjem ugovora");
                return Problem(statusCode: 500);
            }
        }
    }
}