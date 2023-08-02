using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "OsiguravajuceKuce",
                newName: "NazivOsigurava");

            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazivDrzave = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OpisModela = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NacinPlacanja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OpisNacinaPlacanja = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NacinPlacanja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImePrezime = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valuta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazivValute = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valuta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZahtevZaOsiguranje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Napomena = table.Column<string>(type: "TEXT", nullable: false),
                    IdOsigKuce = table.Column<int>(type: "INTEGER", nullable: false),
                    SifraRadnika = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZahtevZaOsiguranje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZahtevZaOsiguranje_OsiguravajuceKuce_IdOsigKuce",
                        column: x => x.IdOsigKuce,
                        principalTable: "OsiguravajuceKuce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZahtevZaOsiguranje_Radnik_SifraRadnika",
                        column: x => x.SifraRadnika,
                        principalTable: "Radnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UgovorOOsiguranju",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Potpisao = table.Column<string>(type: "TEXT", nullable: false),
                    IdDrzave = table.Column<int>(type: "INTEGER", nullable: false),
                    IdOsigKuce = table.Column<int>(type: "INTEGER", nullable: false),
                    SifraRadnika = table.Column<int>(type: "INTEGER", nullable: false),
                    SifraZahteva = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UgovorOOsiguranju", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UgovorOOsiguranju_Drzava_IdDrzave",
                        column: x => x.IdDrzave,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UgovorOOsiguranju_OsiguravajuceKuce_IdOsigKuce",
                        column: x => x.IdOsigKuce,
                        principalTable: "OsiguravajuceKuce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UgovorOOsiguranju_Radnik_SifraRadnika",
                        column: x => x.SifraRadnika,
                        principalTable: "Radnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UgovorOOsiguranju_ZahtevZaOsiguranje_SifraZahteva",
                        column: x => x.SifraZahteva,
                        principalTable: "ZahtevZaOsiguranje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RacunOsiguranja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Iznos = table.Column<double>(type: "REAL", nullable: false),
                    PozivNaBroj = table.Column<string>(type: "TEXT", nullable: false),
                    BrUgovora = table.Column<int>(type: "INTEGER", nullable: false),
                    IdOsigKuce = table.Column<int>(type: "INTEGER", nullable: false),
                    SifraRadnika = table.Column<int>(type: "INTEGER", nullable: false),
                    IdNacinaPlacanja = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacunOsiguranja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RacunOsiguranja_NacinPlacanja_IdNacinaPlacanja",
                        column: x => x.IdNacinaPlacanja,
                        principalTable: "NacinPlacanja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacunOsiguranja_OsiguravajuceKuce_IdOsigKuce",
                        column: x => x.IdOsigKuce,
                        principalTable: "OsiguravajuceKuce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacunOsiguranja_Radnik_SifraRadnika",
                        column: x => x.SifraRadnika,
                        principalTable: "Radnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacunOsiguranja_UgovorOOsiguranju_BrUgovora",
                        column: x => x.BrUgovora,
                        principalTable: "UgovorOOsiguranju",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkaRacunaOsiguranja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazivVrsteOsiguranja = table.Column<string>(type: "TEXT", nullable: false),
                    Cena = table.Column<double>(type: "REAL", nullable: false),
                    IdRacunaOsiguranja = table.Column<int>(type: "INTEGER", nullable: false),
                    RacunOsiguranjaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaRacunaOsiguranja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkaRacunaOsiguranja_RacunOsiguranja_IdRacunaOsiguranja",
                        column: x => x.IdRacunaOsiguranja,
                        principalTable: "RacunOsiguranja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkaRacunaOsiguranja_RacunOsiguranja_RacunOsiguranjaId",
                        column: x => x.RacunOsiguranjaId,
                        principalTable: "RacunOsiguranja",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UplatnicaZaOsiguranje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SvrhaUplate = table.Column<string>(type: "TEXT", nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Iznos = table.Column<double>(type: "REAL", nullable: false),
                    BrojRacuna = table.Column<string>(type: "TEXT", nullable: false),
                    BrRacunaOsig = table.Column<int>(type: "INTEGER", nullable: false),
                    IdModela = table.Column<int>(type: "INTEGER", nullable: false),
                    IdValute = table.Column<int>(type: "INTEGER", nullable: false),
                    SifraRadnika = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UplatnicaZaOsiguranje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UplatnicaZaOsiguranje_Model_IdModela",
                        column: x => x.IdModela,
                        principalTable: "Model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UplatnicaZaOsiguranje_RacunOsiguranja_BrRacunaOsig",
                        column: x => x.BrRacunaOsig,
                        principalTable: "RacunOsiguranja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UplatnicaZaOsiguranje_Radnik_SifraRadnika",
                        column: x => x.SifraRadnika,
                        principalTable: "Radnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UplatnicaZaOsiguranje_Valuta_IdValute",
                        column: x => x.IdValute,
                        principalTable: "Valuta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SvrhaObavestenja = table.Column<string>(type: "TEXT", nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IdUplatnice = table.Column<int>(type: "INTEGER", nullable: false),
                    IdRadnika = table.Column<int>(type: "INTEGER", nullable: false),
                    IdOsiguravajuceKuce = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavestenjeOIzvrsenojUplatiOsiguranja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_OsiguravajuceKuce_IdOsiguravajuceKuce",
                        column: x => x.IdOsiguravajuceKuce,
                        principalTable: "OsiguravajuceKuce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_Radnik_IdRadnika",
                        column: x => x.IdRadnika,
                        principalTable: "Radnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_UplatnicaZaOsiguranje_IdUplatnice",
                        column: x => x.IdUplatnice,
                        principalTable: "UplatnicaZaOsiguranje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdOsiguravajuceKuce",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdOsiguravajuceKuce");

            migrationBuilder.CreateIndex(
                name: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdRadnika",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdRadnika");

            migrationBuilder.CreateIndex(
                name: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdUplatnice");

            migrationBuilder.CreateIndex(
                name: "IX_RacunOsiguranja_BrUgovora",
                table: "RacunOsiguranja",
                column: "BrUgovora");

            migrationBuilder.CreateIndex(
                name: "IX_RacunOsiguranja_IdNacinaPlacanja",
                table: "RacunOsiguranja",
                column: "IdNacinaPlacanja");

            migrationBuilder.CreateIndex(
                name: "IX_RacunOsiguranja_IdOsigKuce",
                table: "RacunOsiguranja",
                column: "IdOsigKuce");

            migrationBuilder.CreateIndex(
                name: "IX_RacunOsiguranja_SifraRadnika",
                table: "RacunOsiguranja",
                column: "SifraRadnika");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacunaOsiguranja_IdRacunaOsiguranja",
                table: "StavkaRacunaOsiguranja",
                column: "IdRacunaOsiguranja");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacunaOsiguranja_RacunOsiguranjaId",
                table: "StavkaRacunaOsiguranja",
                column: "RacunOsiguranjaId");

            migrationBuilder.CreateIndex(
                name: "IX_UgovorOOsiguranju_IdDrzave",
                table: "UgovorOOsiguranju",
                column: "IdDrzave");

            migrationBuilder.CreateIndex(
                name: "IX_UgovorOOsiguranju_IdOsigKuce",
                table: "UgovorOOsiguranju",
                column: "IdOsigKuce");

            migrationBuilder.CreateIndex(
                name: "IX_UgovorOOsiguranju_SifraRadnika",
                table: "UgovorOOsiguranju",
                column: "SifraRadnika");

            migrationBuilder.CreateIndex(
                name: "IX_UgovorOOsiguranju_SifraZahteva",
                table: "UgovorOOsiguranju",
                column: "SifraZahteva");

            migrationBuilder.CreateIndex(
                name: "IX_UplatnicaZaOsiguranje_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje",
                column: "BrRacunaOsig");

            migrationBuilder.CreateIndex(
                name: "IX_UplatnicaZaOsiguranje_IdModela",
                table: "UplatnicaZaOsiguranje",
                column: "IdModela");

            migrationBuilder.CreateIndex(
                name: "IX_UplatnicaZaOsiguranje_IdValute",
                table: "UplatnicaZaOsiguranje",
                column: "IdValute");

            migrationBuilder.CreateIndex(
                name: "IX_UplatnicaZaOsiguranje_SifraRadnika",
                table: "UplatnicaZaOsiguranje",
                column: "SifraRadnika");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtevZaOsiguranje_IdOsigKuce",
                table: "ZahtevZaOsiguranje",
                column: "IdOsigKuce");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtevZaOsiguranje_SifraRadnika",
                table: "ZahtevZaOsiguranje",
                column: "SifraRadnika");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropTable(
                name: "StavkaRacunaOsiguranja");

            migrationBuilder.DropTable(
                name: "UplatnicaZaOsiguranje");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "RacunOsiguranja");

            migrationBuilder.DropTable(
                name: "Valuta");

            migrationBuilder.DropTable(
                name: "NacinPlacanja");

            migrationBuilder.DropTable(
                name: "UgovorOOsiguranju");

            migrationBuilder.DropTable(
                name: "Drzava");

            migrationBuilder.DropTable(
                name: "ZahtevZaOsiguranje");

            migrationBuilder.DropTable(
                name: "Radnik");

            migrationBuilder.RenameColumn(
                name: "NazivOsigurava",
                table: "OsiguravajuceKuce",
                newName: "Name");
        }
    }
}
