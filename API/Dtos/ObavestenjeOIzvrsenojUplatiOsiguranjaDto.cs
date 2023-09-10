using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ObavestenjeOIzvrsenojUplatiOsiguranjaDto
    {
        public int Id { get; set; }
        public string SvrhaObavestenja { get; set; }
        public DateTime Datum { get; set; }
        public int IdUplatnice { get; set; }
        public int SifraRadnika { get; set; }
        public int IdOsigKuce { get; set; }
        public RadnikDto Radnik { get; set; }
        public OsiguravajucaKucaDto OsiguravajucaKuca { get; set; }
    }
}
