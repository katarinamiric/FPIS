using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using Microsoft.VisualBasic;

namespace API.Responses
{
    public class ObavestenjeResponse
    {
        public List<ObavestenjeOIzvrsenojUplatiOsiguranjaDto> Obavestenja { get; set; }
        public ObavestenjeResponse(List<ObavestenjeOIzvrsenojUplatiOsiguranjaDto> obavestenja)
        {
            Obavestenja = obavestenja;
        }
       
    }
}