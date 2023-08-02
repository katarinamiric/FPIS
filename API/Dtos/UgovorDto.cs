using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class UgovorDto
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Potpisao { get; set; }
        public int? IdDrzave { get; set; }
        public int? SifraZahteva { get; set; }
        public int? SifraRadnika { get; set; }
    }
}