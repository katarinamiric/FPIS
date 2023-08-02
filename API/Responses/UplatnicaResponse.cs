using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;

namespace API.Responses
{
    public class UplatnicaResponse
    {
        public UplatnicaResponse()
        {
            
        }
        public UplatnicaResponse(List<UplatnicaZaOsiguranjeDto> uplatnice)
        {
            Uplatnice = uplatnice;
        }

        public List<UplatnicaZaOsiguranjeDto> Uplatnice { get; set; }
    }
}