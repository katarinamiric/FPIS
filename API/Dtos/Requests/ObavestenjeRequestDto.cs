using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.Requests
{
    public class ObavestenjeRequestDto
    {
        public string SvrhaObavestenja { get; set; }
        public DateTime Datum { get; set; }
        public int IdOsigKuce { get; set; }
        public int SifraRadnika { get; set; }
        public int IdUplatnice { get; set; }
    }
}
