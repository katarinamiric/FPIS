namespace API.Dtos
{
    public class UplatnicaZaOsiguranjeDto
    {
        public int Id { get; set; }
        public string SvrhaUplate { get; set; }
        public DateTime Datum { get; set; }
        public double Iznos { get; set; }
        public string BrojRacuna { get; set; }
        // public virtual RacunOsiguranjaDto RacunOsiguranja { get; set; }
        
        // public virtual ModelDto Model { get; set; }
        // public virtual ValutaDto Valuta { get; set; }
        // public virtual RadnikDto Radnik { get; set; }

    }
}