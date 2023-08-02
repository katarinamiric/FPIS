using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class ZahtevZaOsiguranje
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public int IdOsigKuce { get; set; }
        public virtual OsiguravajucaKuca OsiguravajucaKuca { get; set; }
        public int SifraRadnika { get; set; }
        public virtual Radnik Radnik { get; set; }

    }
}