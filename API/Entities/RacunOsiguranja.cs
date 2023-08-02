using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class RacunOsiguranja
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public double Iznos { get; set; }
        public string PozivNaBroj { get; set; }
        public int BrUgovora { get; set; }
        public virtual UgovorOOsiguranju Ugovor { get; set; }
        public int? IdOsigKuce { get; set; }
        public virtual OsiguravajucaKuca OsiguravajucaKuca { get; set; }
        public int SifraRadnika { get; set; }
        public virtual Radnik Radnik { get; set; }
        public int IdNacinaPlacanja { get; set; }
        public virtual NacinPlacanja NacinPlacanja { get; set; }
        private ICollection<StavkaRacunaOsiguranja> _stavkeRacunaOsiguranja;
        public virtual ICollection<StavkaRacunaOsiguranja> StavkeRacunaOsiguranja
        {
            get => _stavkeRacunaOsiguranja ??= new HashSet<StavkaRacunaOsiguranja>(); 
            set => _stavkeRacunaOsiguranja = value;
        }
    }
}