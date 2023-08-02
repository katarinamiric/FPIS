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
        public int OsiguravajucaKucaId { get; set; }
        public int RadnikId { get; set; }
        public int UplatnicaId { get; set; }
    }
}