using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<OsiguravajucaKuca> OsiguravajuceKuce { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Model> Modeli { get; set; }
        public DbSet<NacinPlacanja> NaciniPlacanja { get; set; }
        public DbSet<ObavestenjeOIzvrsenojUplatiOsiguranja> ObavestenjaOIzvrsenojUplatiOsiguranja { get; set; }
        public DbSet<Radnik> Radnici { get; set; }
        public DbSet<StavkaRacunaOsiguranja> StavkeRacunaOsiguranja { get; set; }
        public DbSet<RacunOsiguranja> RacuniOsiguranja { get; set; }
        public DbSet<UgovorOOsiguranju?> UgovoriOOsiguranju { get; set; }
        public DbSet<UplatnicaZaOsiguranje> UplatniceZaOsiguranje { get; set; }
        public DbSet<Valuta> Valute { get; set; }
        public DbSet<ZahtevZaOsiguranje> ZahteviZaOsiguranje { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Drzava>()
            .ToTable(nameof(Drzava))
            .HasKey(x => x.Id);

            builder.Entity<Model>()
            .ToTable(nameof(Model))
            .HasKey(x => x.Id);

            builder.Entity<NacinPlacanja>()
            .ToTable(nameof(NacinPlacanja))
            .HasKey(x => x.Id);

            builder.Entity<ObavestenjeOIzvrsenojUplatiOsiguranja>(entity =>
            {
                entity.ToTable(nameof(ObavestenjeOIzvrsenojUplatiOsiguranja));

                entity.HasOne(x => x.Uplatnica)
                .WithMany()
                .HasForeignKey(x => x.IdUplatnice);

                entity.HasOne(x => x.Radnik)
                .WithMany()
                .HasForeignKey(x => x.IdRadnika);

                entity.HasOne(x => x.OsiguravajucaKuca)
                .WithMany()
                .HasForeignKey(x => x.IdOsiguravajuceKuce);
                entity.HasKey(x => x.Id);

            });



            builder.Entity<OsiguravajucaKuca>()
            .ToTable(nameof(OsiguravajucaKuca))
            .HasKey(x => x.Id);

            builder.Entity<Radnik>()
            .ToTable(nameof(Radnik))
            .HasKey(x => x.Id);

            builder.Entity<Valuta>()
            .ToTable(nameof(Valuta))
            .HasKey(x => x.Id);

            builder.Entity<RacunOsiguranja>(entity =>
            {
                entity.ToTable(nameof(RacuniOsiguranja));

                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.Ugovor)
               .WithMany()
               .HasForeignKey(x => x.BrUgovora);

                entity.HasOne(x => x.OsiguravajucaKuca)
               .WithMany()
               .HasForeignKey(x => x.IdOsigKuce);

                entity.HasOne(x => x.Radnik)
               .WithMany()
               .HasForeignKey(x => x.SifraRadnika);

                entity.HasOne(x => x.NacinPlacanja)
               .WithMany()
               .HasForeignKey(x => x.IdNacinaPlacanja);

                entity.HasMany(x => x.StavkeRacunaOsiguranja)
               .WithOne(x => x.RacunOsiguranja)
               .HasForeignKey(x => x.IdRacunaOsiguranja);

            });


            builder.Entity<StavkaRacunaOsiguranja>(entity =>
            {
                entity.ToTable(nameof(StavkaRacunaOsiguranja));

                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.RacunOsiguranja)
                .WithMany(x => x.StavkeRacunaOsiguranja)
                .HasForeignKey(x => x.IdRacunaOsiguranja);

            });


            builder.Entity<UgovorOOsiguranju>(entity =>
            {
                entity.ToTable(nameof(UgovorOOsiguranju));

                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.Drzava)
                .WithMany()
                .HasForeignKey(x => x.IdDrzave);
                entity.HasOne(x => x.OsiguravajucaKuca)
                .WithMany()
                .HasForeignKey(x => x.IdOsigKuce);
                entity.HasOne(x => x.Radnik)
                .WithMany()
                .HasForeignKey(x => x.SifraRadnika);
                entity.HasOne(x => x.Zahtev)
                .WithMany()
                .HasForeignKey(x => x.SifraZahteva);

            });

            builder.Entity<UplatnicaZaOsiguranje>(entity =>
            {
                entity.ToTable(nameof(UplatnicaZaOsiguranje));

                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.RacunOsiguranja)
                .WithMany()
                .HasForeignKey(x => x.BrRacunaOsig);
                entity.HasOne(x => x.Model)
                .WithMany()
                .HasForeignKey(x => x.IdModela);
                entity.HasOne(x => x.Valuta)
                .WithMany()
                .HasForeignKey(x => x.IdValute);
                entity.HasOne(x => x.Radnik)
                .WithMany()
                .HasForeignKey(x => x.SifraRadnika);

            });

            builder.Entity<ZahtevZaOsiguranje>(entity =>
            {
                entity.ToTable(nameof(ZahtevZaOsiguranje));

                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.OsiguravajucaKuca)
                .WithMany()
                .HasForeignKey(x => x.IdOsigKuce);
                entity.HasOne(x => x.Radnik)
                .WithMany()
                .HasForeignKey(x => x.SifraRadnika);

            });


        }

    }
}