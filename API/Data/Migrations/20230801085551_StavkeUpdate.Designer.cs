﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230801085551_StavkeUpdate")]
    partial class StavkeUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("API.Entities.Drzava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazivDrzave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("API.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OpisModela")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Modeli");
                });

            modelBuilder.Entity("API.Entities.NacinPlacanja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OpisNacinaPlacanja")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NaciniPlacanja");
                });

            modelBuilder.Entity("API.Entities.ObavestenjeOIzvrsenojUplatiOsiguranja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdOsiguravajuceKuce")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdRadnika")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUplatnice")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SvrhaObavestenja")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdOsiguravajuceKuce");

                    b.HasIndex("IdRadnika");

                    b.HasIndex("IdUplatnice");

                    b.ToTable("ObavestenjaOIzvrsenojUplatiOsiguranja");
                });

            modelBuilder.Entity("API.Entities.OsiguravajucaKuca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazivOsigurava")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OsiguravajuceKuce");
                });

            modelBuilder.Entity("API.Entities.RacunOsiguranja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrUgovora")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdNacinaPlacanja")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdOsigKuce")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Iznos")
                        .HasColumnType("REAL");

                    b.Property<string>("PozivNaBroj")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SifraRadnika")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BrUgovora");

                    b.HasIndex("IdNacinaPlacanja");

                    b.HasIndex("IdOsigKuce");

                    b.HasIndex("SifraRadnika");

                    b.ToTable("RacuniOsiguranja");
                });

            modelBuilder.Entity("API.Entities.Radnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Radnici");
                });

            modelBuilder.Entity("API.Entities.StavkaRacunaOsiguranja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cena")
                        .HasColumnType("REAL");

                    b.Property<int>("IdRacunaOsiguranja")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazivVrsteOsiguranja")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdRacunaOsiguranja");

                    b.ToTable("StavkeRacunaOsiguranja");
                });

            modelBuilder.Entity("API.Entities.UgovorOOsiguranju", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdDrzave")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdOsigKuce")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Potpisao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SifraRadnika")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SifraZahteva")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdDrzave");

                    b.HasIndex("IdOsigKuce");

                    b.HasIndex("SifraRadnika");

                    b.HasIndex("SifraZahteva");

                    b.ToTable("UgovoriOOsiguranju");
                });

            modelBuilder.Entity("API.Entities.UplatnicaZaOsiguranje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrRacunaOsig")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrojRacuna")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdModela")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdValute")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Iznos")
                        .HasColumnType("REAL");

                    b.Property<int>("SifraRadnika")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SvrhaUplate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrRacunaOsig");

                    b.HasIndex("IdModela");

                    b.HasIndex("IdValute");

                    b.HasIndex("SifraRadnika");

                    b.ToTable("UplatniceZaOsiguranje");
                });

            modelBuilder.Entity("API.Entities.Valuta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazivValute")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Valute");
                });

            modelBuilder.Entity("API.Entities.ZahtevZaOsiguranje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdOsigKuce")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Napomena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SifraRadnika")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdOsigKuce");

                    b.HasIndex("SifraRadnika");

                    b.ToTable("ZahteviZaOsiguranje");
                });

            modelBuilder.Entity("API.Entities.ObavestenjeOIzvrsenojUplatiOsiguranja", b =>
                {
                    b.HasOne("API.Entities.OsiguravajucaKuca", "OsiguravajucaKuca")
                        .WithMany()
                        .HasForeignKey("IdOsiguravajuceKuce")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("IdRadnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.UplatnicaZaOsiguranje", "Uplatnica")
                        .WithMany()
                        .HasForeignKey("IdUplatnice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OsiguravajucaKuca");

                    b.Navigation("Radnik");

                    b.Navigation("Uplatnica");
                });

            modelBuilder.Entity("API.Entities.RacunOsiguranja", b =>
                {
                    b.HasOne("API.Entities.UgovorOOsiguranju", "Ugovor")
                        .WithMany()
                        .HasForeignKey("BrUgovora")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.NacinPlacanja", "NacinPlacanja")
                        .WithMany()
                        .HasForeignKey("IdNacinaPlacanja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.OsiguravajucaKuca", "OsiguravajucaKuca")
                        .WithMany()
                        .HasForeignKey("IdOsigKuce")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("SifraRadnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NacinPlacanja");

                    b.Navigation("OsiguravajucaKuca");

                    b.Navigation("Radnik");

                    b.Navigation("Ugovor");
                });

            modelBuilder.Entity("API.Entities.StavkaRacunaOsiguranja", b =>
                {
                    b.HasOne("API.Entities.RacunOsiguranja", "RacunOsiguranja")
                        .WithMany("StavkeRacunaOsiguranja")
                        .HasForeignKey("IdRacunaOsiguranja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RacunOsiguranja");
                });

            modelBuilder.Entity("API.Entities.UgovorOOsiguranju", b =>
                {
                    b.HasOne("API.Entities.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("IdDrzave")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.OsiguravajucaKuca", "OsiguravajucaKuca")
                        .WithMany()
                        .HasForeignKey("IdOsigKuce")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("SifraRadnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.ZahtevZaOsiguranje", "Zahtev")
                        .WithMany()
                        .HasForeignKey("SifraZahteva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");

                    b.Navigation("OsiguravajucaKuca");

                    b.Navigation("Radnik");

                    b.Navigation("Zahtev");
                });

            modelBuilder.Entity("API.Entities.UplatnicaZaOsiguranje", b =>
                {
                    b.HasOne("API.Entities.RacunOsiguranja", "RacunOsiguranja")
                        .WithMany()
                        .HasForeignKey("BrRacunaOsig")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("IdModela")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Valuta", "Valuta")
                        .WithMany()
                        .HasForeignKey("IdValute")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("SifraRadnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");

                    b.Navigation("RacunOsiguranja");

                    b.Navigation("Radnik");

                    b.Navigation("Valuta");
                });

            modelBuilder.Entity("API.Entities.ZahtevZaOsiguranje", b =>
                {
                    b.HasOne("API.Entities.OsiguravajucaKuca", "OsiguravajucaKuca")
                        .WithMany()
                        .HasForeignKey("IdOsigKuce")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("SifraRadnika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OsiguravajucaKuca");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("API.Entities.RacunOsiguranja", b =>
                {
                    b.Navigation("StavkeRacunaOsiguranja");
                });
#pragma warning restore 612, 618
        }
    }
}
