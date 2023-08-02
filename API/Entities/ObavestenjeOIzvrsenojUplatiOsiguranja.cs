using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class ObavestenjeOIzvrsenojUplatiOsiguranja
    {
        public int Id { get; set; }
        public string SvrhaObavestenja { get; set; }
        public DateTime Datum { get; set; }
        public int IdUplatnice { get; set; }
        public virtual UplatnicaZaOsiguranje Uplatnica { get; set; }
        public int IdRadnika { get; set; }
        public virtual Radnik Radnik { get; set; }
        public int IdOsiguravajuceKuce { get; set; }
        public virtual OsiguravajucaKuca OsiguravajucaKuca { get; set; }
    }
}