using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class UplatnicaZaOsiguranje
    {
        public int Id { get; set; }
        public string SvrhaUplate { get; set; }
        public DateTime Datum { get; set; }
        public double Iznos { get; set; }
        public string BrojRacuna { get; set; }
        public int? BrRacunaOsig { get; set; }
        public virtual RacunOsiguranja RacunOsiguranja { get; set; }
        
        public int IdModela { get; set; }
        public virtual Model Model { get; set; }
        public int IdValute { get; set; }
        public virtual Valuta Valuta { get; set; }
        public int SifraRadnika { get; set; }
        public virtual Radnik Radnik { get; set; }

    }
}