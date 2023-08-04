using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ObavestenjeOIzvrsenojUplatiOsiguranjaController : ControllerBase
    {
        private readonly ILogger<ObavestenjeOIzvrsenojUplatiOsiguranjaController> _logger;
        private readonly IObavestenjeOIzvrsenojUplatiService _obavestenjeService;

        public ObavestenjeOIzvrsenojUplatiOsiguranjaController(ILogger<ObavestenjeOIzvrsenojUplatiOsiguranjaController> logger, IObavestenjeOIzvrsenojUplatiService obavestenjeService)
        {
            _logger = logger;
            _obavestenjeService = obavestenjeService;
        }


      
        


    }
}