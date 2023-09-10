using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.Requests
{
    public class RacunRequestDto
    {
        public string PozivNaBroj { get; set; }
        public DateTime Datum { get; set; }
        public int BrojUgovora { get; set; }
        public int NacinPlacanjaId { get; set; }
        public int SifraRadnika { get; set; }
        public List<StavkaRacunaRequestDto> Stavke { get; set; }
public double Iznos { get; set; }
    }
}
