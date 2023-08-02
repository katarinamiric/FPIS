using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class UgovorOOsiguranju
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Potpisao { get; set; }
        public int IdDrzave { get; set; }
        public virtual Drzava Drzava { get; set; }
        public int IdOsigKuce { get; set; }
        public virtual OsiguravajucaKuca OsiguravajucaKuca { get; set; }
        public int SifraRadnika { get; set; }
        public virtual Radnik Radnik { get; set; }
        public int SifraZahteva { get; set; }
        public virtual ZahtevZaOsiguranje Zahtev { get; set; }

    }
}