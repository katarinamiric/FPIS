using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_OsiguravajuceKuce_IdOsiguravajuceKuce",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_Radnik_IdRadnika",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_UplatnicaZaOsiguranje_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacunOsiguranja_NacinPlacanja_IdNacinaPlacanja",
                table: "RacunOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacunOsiguranja_OsiguravajuceKuce_IdOsigKuce",
                table: "RacunOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacunOsiguranja_Radnik_SifraRadnika",
                table: "RacunOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacunOsiguranja_UgovorOOsiguranju_BrUgovora",
                table: "RacunOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacunaOsiguranja_RacunOsiguranja_IdRacunaOsiguranja",
                table: "StavkaRacunaOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacunaOsiguranja_RacunOsiguranja_RacunOsiguranjaId",
                table: "StavkaRacunaOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovorOOsiguranju_Drzava_IdDrzave",
                table: "UgovorOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovorOOsiguranju_OsiguravajuceKuce_IdOsigKuce",
                table: "UgovorOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovorOOsiguranju_Radnik_SifraRadnika",
                table: "UgovorOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovorOOsiguranju_ZahtevZaOsiguranje_SifraZahteva",
                table: "UgovorOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatnicaZaOsiguranje_Model_IdModela",
                table: "UplatnicaZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatnicaZaOsiguranje_RacunOsiguranja_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatnicaZaOsiguranje_Radnik_SifraRadnika",
                table: "UplatnicaZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatnicaZaOsiguranje_Valuta_IdValute",
                table: "UplatnicaZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahtevZaOsiguranje_OsiguravajuceKuce_IdOsigKuce",
                table: "ZahtevZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahtevZaOsiguranje_Radnik_SifraRadnika",
                table: "ZahtevZaOsiguranje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZahtevZaOsiguranje",
                table: "ZahtevZaOsiguranje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Valuta",
                table: "Valuta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UplatnicaZaOsiguranje",
                table: "UplatnicaZaOsiguranje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UgovorOOsiguranju",
                table: "UgovorOOsiguranju");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StavkaRacunaOsiguranja",
                table: "StavkaRacunaOsiguranja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Radnik",
                table: "Radnik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RacunOsiguranja",
                table: "RacunOsiguranja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObavestenjeOIzvrsenojUplatiOsiguranja",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NacinPlacanja",
                table: "NacinPlacanja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drzava",
                table: "Drzava");

            migrationBuilder.RenameTable(
                name: "ZahtevZaOsiguranje",
                newName: "ZahteviZaOsiguranje");

            migrationBuilder.RenameTable(
                name: "Valuta",
                newName: "Valute");

            migrationBuilder.RenameTable(
                name: "UplatnicaZaOsiguranje",
                newName: "UplatniceZaOsiguranje");

            migrationBuilder.RenameTable(
                name: "UgovorOOsiguranju",
                newName: "UgovoriOOsiguranju");

            migrationBuilder.RenameTable(
                name: "StavkaRacunaOsiguranja",
                newName: "StavkeRacunaOsiguranja");

            migrationBuilder.RenameTable(
                name: "Radnik",
                newName: "Radnici");

            migrationBuilder.RenameTable(
                name: "RacunOsiguranja",
                newName: "RacuniOsiguranja");

            migrationBuilder.RenameTable(
                name: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                newName: "ObavestenjaOIzvrsenojUplatiOsiguranja");

            migrationBuilder.RenameTable(
                name: "NacinPlacanja",
                newName: "NaciniPlacanja");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Modeli");

            migrationBuilder.RenameTable(
                name: "Drzava",
                newName: "Drzave");

            migrationBuilder.RenameIndex(
                name: "IX_ZahtevZaOsiguranje_SifraRadnika",
                table: "ZahteviZaOsiguranje",
                newName: "IX_ZahteviZaOsiguranje_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_ZahtevZaOsiguranje_IdOsigKuce",
                table: "ZahteviZaOsiguranje",
                newName: "IX_ZahteviZaOsiguranje_IdOsigKuce");

            migrationBuilder.RenameIndex(
                name: "IX_UplatnicaZaOsiguranje_SifraRadnika",
                table: "UplatniceZaOsiguranje",
                newName: "IX_UplatniceZaOsiguranje_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_UplatnicaZaOsiguranje_IdValute",
                table: "UplatniceZaOsiguranje",
                newName: "IX_UplatniceZaOsiguranje_IdValute");

            migrationBuilder.RenameIndex(
                name: "IX_UplatnicaZaOsiguranje_IdModela",
                table: "UplatniceZaOsiguranje",
                newName: "IX_UplatniceZaOsiguranje_IdModela");

            migrationBuilder.RenameIndex(
                name: "IX_UplatnicaZaOsiguranje_BrRacunaOsig",
                table: "UplatniceZaOsiguranje",
                newName: "IX_UplatniceZaOsiguranje_BrRacunaOsig");

            migrationBuilder.RenameIndex(
                name: "IX_UgovorOOsiguranju_SifraZahteva",
                table: "UgovoriOOsiguranju",
                newName: "IX_UgovoriOOsiguranju_SifraZahteva");

            migrationBuilder.RenameIndex(
                name: "IX_UgovorOOsiguranju_SifraRadnika",
                table: "UgovoriOOsiguranju",
                newName: "IX_UgovoriOOsiguranju_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_UgovorOOsiguranju_IdOsigKuce",
                table: "UgovoriOOsiguranju",
                newName: "IX_UgovoriOOsiguranju_IdOsigKuce");

            migrationBuilder.RenameIndex(
                name: "IX_UgovorOOsiguranju_IdDrzave",
                table: "UgovoriOOsiguranju",
                newName: "IX_UgovoriOOsiguranju_IdDrzave");

            migrationBuilder.RenameIndex(
                name: "IX_StavkaRacunaOsiguranja_RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja",
                newName: "IX_StavkeRacunaOsiguranja_RacunOsiguranjaId");

            migrationBuilder.RenameIndex(
                name: "IX_StavkaRacunaOsiguranja_IdRacunaOsiguranja",
                table: "StavkeRacunaOsiguranja",
                newName: "IX_StavkeRacunaOsiguranja_IdRacunaOsiguranja");

            migrationBuilder.RenameIndex(
                name: "IX_RacunOsiguranja_SifraRadnika",
                table: "RacuniOsiguranja",
                newName: "IX_RacuniOsiguranja_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_RacunOsiguranja_IdOsigKuce",
                table: "RacuniOsiguranja",
                newName: "IX_RacuniOsiguranja_IdOsigKuce");

            migrationBuilder.RenameIndex(
                name: "IX_RacunOsiguranja_IdNacinaPlacanja",
                table: "RacuniOsiguranja",
                newName: "IX_RacuniOsiguranja_IdNacinaPlacanja");

            migrationBuilder.RenameIndex(
                name: "IX_RacunOsiguranja_BrUgovora",
                table: "RacuniOsiguranja",
                newName: "IX_RacuniOsiguranja_BrUgovora");

            migrationBuilder.RenameIndex(
                name: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdUplatnice",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                newName: "IX_ObavestenjaOIzvrsenojUplatiOsiguranja_IdUplatnice");

            migrationBuilder.RenameIndex(
                name: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdRadnika",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                newName: "IX_ObavestenjaOIzvrsenojUplatiOsiguranja_IdRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdOsiguravajuceKuce",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                newName: "IX_ObavestenjaOIzvrsenojUplatiOsiguranja_IdOsiguravajuceKuce");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZahteviZaOsiguranje",
                table: "ZahteviZaOsiguranje",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Valute",
                table: "Valute",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UplatniceZaOsiguranje",
                table: "UplatniceZaOsiguranje",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UgovoriOOsiguranju",
                table: "UgovoriOOsiguranju",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StavkeRacunaOsiguranja",
                table: "StavkeRacunaOsiguranja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Radnici",
                table: "Radnici",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RacuniOsiguranja",
                table: "RacuniOsiguranja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObavestenjaOIzvrsenojUplatiOsiguranja",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NaciniPlacanja",
                table: "NaciniPlacanja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modeli",
                table: "Modeli",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drzave",
                table: "Drzave",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjaOIzvrsenojUplatiOsiguranja_OsiguravajuceKuce_IdOsiguravajuceKuce",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                column: "IdOsiguravajuceKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjaOIzvrsenojUplatiOsiguranja_Radnici_IdRadnika",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                column: "IdRadnika",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjaOIzvrsenojUplatiOsiguranja_UplatniceZaOsiguranje_IdUplatnice",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                column: "IdUplatnice",
                principalTable: "UplatniceZaOsiguranje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_NaciniPlacanja_IdNacinaPlacanja",
                table: "RacuniOsiguranja",
                column: "IdNacinaPlacanja",
                principalTable: "NaciniPlacanja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_OsiguravajuceKuce_IdOsigKuce",
                table: "RacuniOsiguranja",
                column: "IdOsigKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_Radnici_SifraRadnika",
                table: "RacuniOsiguranja",
                column: "SifraRadnika",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_UgovoriOOsiguranju_BrUgovora",
                table: "RacuniOsiguranja",
                column: "BrUgovora",
                principalTable: "UgovoriOOsiguranju",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeRacunaOsiguranja_RacuniOsiguranja_IdRacunaOsiguranja",
                table: "StavkeRacunaOsiguranja",
                column: "IdRacunaOsiguranja",
                principalTable: "RacuniOsiguranja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeRacunaOsiguranja_RacuniOsiguranja_RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja",
                column: "RacunOsiguranjaId",
                principalTable: "RacuniOsiguranja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UgovoriOOsiguranju_Drzave_IdDrzave",
                table: "UgovoriOOsiguranju",
                column: "IdDrzave",
                principalTable: "Drzave",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UgovoriOOsiguranju_OsiguravajuceKuce_IdOsigKuce",
                table: "UgovoriOOsiguranju",
                column: "IdOsigKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UgovoriOOsiguranju_Radnici_SifraRadnika",
                table: "UgovoriOOsiguranju",
                column: "SifraRadnika",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UgovoriOOsiguranju_ZahteviZaOsiguranje_SifraZahteva",
                table: "UgovoriOOsiguranju",
                column: "SifraZahteva",
                principalTable: "ZahteviZaOsiguranje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatniceZaOsiguranje_Modeli_IdModela",
                table: "UplatniceZaOsiguranje",
                column: "IdModela",
                principalTable: "Modeli",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatniceZaOsiguranje_RacuniOsiguranja_BrRacunaOsig",
                table: "UplatniceZaOsiguranje",
                column: "BrRacunaOsig",
                principalTable: "RacuniOsiguranja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatniceZaOsiguranje_Radnici_SifraRadnika",
                table: "UplatniceZaOsiguranje",
                column: "SifraRadnika",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatniceZaOsiguranje_Valute_IdValute",
                table: "UplatniceZaOsiguranje",
                column: "IdValute",
                principalTable: "Valute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahteviZaOsiguranje_OsiguravajuceKuce_IdOsigKuce",
                table: "ZahteviZaOsiguranje",
                column: "IdOsigKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahteviZaOsiguranje_Radnici_SifraRadnika",
                table: "ZahteviZaOsiguranje",
                column: "SifraRadnika",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjaOIzvrsenojUplatiOsiguranja_OsiguravajuceKuce_IdOsiguravajuceKuce",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjaOIzvrsenojUplatiOsiguranja_Radnici_IdRadnika",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjaOIzvrsenojUplatiOsiguranja_UplatniceZaOsiguranje_IdUplatnice",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_NaciniPlacanja_IdNacinaPlacanja",
                table: "RacuniOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_OsiguravajuceKuce_IdOsigKuce",
                table: "RacuniOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_Radnici_SifraRadnika",
                table: "RacuniOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_UgovoriOOsiguranju_BrUgovora",
                table: "RacuniOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeRacunaOsiguranja_RacuniOsiguranja_IdRacunaOsiguranja",
                table: "StavkeRacunaOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeRacunaOsiguranja_RacuniOsiguranja_RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovoriOOsiguranju_Drzave_IdDrzave",
                table: "UgovoriOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovoriOOsiguranju_OsiguravajuceKuce_IdOsigKuce",
                table: "UgovoriOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovoriOOsiguranju_Radnici_SifraRadnika",
                table: "UgovoriOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UgovoriOOsiguranju_ZahteviZaOsiguranje_SifraZahteva",
                table: "UgovoriOOsiguranju");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatniceZaOsiguranje_Modeli_IdModela",
                table: "UplatniceZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatniceZaOsiguranje_RacuniOsiguranja_BrRacunaOsig",
                table: "UplatniceZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatniceZaOsiguranje_Radnici_SifraRadnika",
                table: "UplatniceZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_UplatniceZaOsiguranje_Valute_IdValute",
                table: "UplatniceZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahteviZaOsiguranje_OsiguravajuceKuce_IdOsigKuce",
                table: "ZahteviZaOsiguranje");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahteviZaOsiguranje_Radnici_SifraRadnika",
                table: "ZahteviZaOsiguranje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZahteviZaOsiguranje",
                table: "ZahteviZaOsiguranje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Valute",
                table: "Valute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UplatniceZaOsiguranje",
                table: "UplatniceZaOsiguranje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UgovoriOOsiguranju",
                table: "UgovoriOOsiguranju");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StavkeRacunaOsiguranja",
                table: "StavkeRacunaOsiguranja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Radnici",
                table: "Radnici");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RacuniOsiguranja",
                table: "RacuniOsiguranja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObavestenjaOIzvrsenojUplatiOsiguranja",
                table: "ObavestenjaOIzvrsenojUplatiOsiguranja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NaciniPlacanja",
                table: "NaciniPlacanja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modeli",
                table: "Modeli");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drzave",
                table: "Drzave");

            migrationBuilder.RenameTable(
                name: "ZahteviZaOsiguranje",
                newName: "ZahtevZaOsiguranje");

            migrationBuilder.RenameTable(
                name: "Valute",
                newName: "Valuta");

            migrationBuilder.RenameTable(
                name: "UplatniceZaOsiguranje",
                newName: "UplatnicaZaOsiguranje");

            migrationBuilder.RenameTable(
                name: "UgovoriOOsiguranju",
                newName: "UgovorOOsiguranju");

            migrationBuilder.RenameTable(
                name: "StavkeRacunaOsiguranja",
                newName: "StavkaRacunaOsiguranja");

            migrationBuilder.RenameTable(
                name: "Radnici",
                newName: "Radnik");

            migrationBuilder.RenameTable(
                name: "RacuniOsiguranja",
                newName: "RacunOsiguranja");

            migrationBuilder.RenameTable(
                name: "ObavestenjaOIzvrsenojUplatiOsiguranja",
                newName: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.RenameTable(
                name: "NaciniPlacanja",
                newName: "NacinPlacanja");

            migrationBuilder.RenameTable(
                name: "Modeli",
                newName: "Model");

            migrationBuilder.RenameTable(
                name: "Drzave",
                newName: "Drzava");

            migrationBuilder.RenameIndex(
                name: "IX_ZahteviZaOsiguranje_SifraRadnika",
                table: "ZahtevZaOsiguranje",
                newName: "IX_ZahtevZaOsiguranje_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_ZahteviZaOsiguranje_IdOsigKuce",
                table: "ZahtevZaOsiguranje",
                newName: "IX_ZahtevZaOsiguranje_IdOsigKuce");

            migrationBuilder.RenameIndex(
                name: "IX_UplatniceZaOsiguranje_SifraRadnika",
                table: "UplatnicaZaOsiguranje",
                newName: "IX_UplatnicaZaOsiguranje_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_UplatniceZaOsiguranje_IdValute",
                table: "UplatnicaZaOsiguranje",
                newName: "IX_UplatnicaZaOsiguranje_IdValute");

            migrationBuilder.RenameIndex(
                name: "IX_UplatniceZaOsiguranje_IdModela",
                table: "UplatnicaZaOsiguranje",
                newName: "IX_UplatnicaZaOsiguranje_IdModela");

            migrationBuilder.RenameIndex(
                name: "IX_UplatniceZaOsiguranje_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje",
                newName: "IX_UplatnicaZaOsiguranje_BrRacunaOsig");

            migrationBuilder.RenameIndex(
                name: "IX_UgovoriOOsiguranju_SifraZahteva",
                table: "UgovorOOsiguranju",
                newName: "IX_UgovorOOsiguranju_SifraZahteva");

            migrationBuilder.RenameIndex(
                name: "IX_UgovoriOOsiguranju_SifraRadnika",
                table: "UgovorOOsiguranju",
                newName: "IX_UgovorOOsiguranju_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_UgovoriOOsiguranju_IdOsigKuce",
                table: "UgovorOOsiguranju",
                newName: "IX_UgovorOOsiguranju_IdOsigKuce");

            migrationBuilder.RenameIndex(
                name: "IX_UgovoriOOsiguranju_IdDrzave",
                table: "UgovorOOsiguranju",
                newName: "IX_UgovorOOsiguranju_IdDrzave");

            migrationBuilder.RenameIndex(
                name: "IX_StavkeRacunaOsiguranja_RacunOsiguranjaId",
                table: "StavkaRacunaOsiguranja",
                newName: "IX_StavkaRacunaOsiguranja_RacunOsiguranjaId");

            migrationBuilder.RenameIndex(
                name: "IX_StavkeRacunaOsiguranja_IdRacunaOsiguranja",
                table: "StavkaRacunaOsiguranja",
                newName: "IX_StavkaRacunaOsiguranja_IdRacunaOsiguranja");

            migrationBuilder.RenameIndex(
                name: "IX_RacuniOsiguranja_SifraRadnika",
                table: "RacunOsiguranja",
                newName: "IX_RacunOsiguranja_SifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_RacuniOsiguranja_IdOsigKuce",
                table: "RacunOsiguranja",
                newName: "IX_RacunOsiguranja_IdOsigKuce");

            migrationBuilder.RenameIndex(
                name: "IX_RacuniOsiguranja_IdNacinaPlacanja",
                table: "RacunOsiguranja",
                newName: "IX_RacunOsiguranja_IdNacinaPlacanja");

            migrationBuilder.RenameIndex(
                name: "IX_RacuniOsiguranja_BrUgovora",
                table: "RacunOsiguranja",
                newName: "IX_RacunOsiguranja_BrUgovora");

            migrationBuilder.RenameIndex(
                name: "IX_ObavestenjaOIzvrsenojUplatiOsiguranja_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                newName: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdUplatnice");

            migrationBuilder.RenameIndex(
                name: "IX_ObavestenjaOIzvrsenojUplatiOsiguranja_IdRadnika",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                newName: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_ObavestenjaOIzvrsenojUplatiOsiguranja_IdOsiguravajuceKuce",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                newName: "IX_ObavestenjeOIzvrsenojUplatiOsiguranja_IdOsiguravajuceKuce");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZahtevZaOsiguranje",
                table: "ZahtevZaOsiguranje",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Valuta",
                table: "Valuta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UplatnicaZaOsiguranje",
                table: "UplatnicaZaOsiguranje",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UgovorOOsiguranju",
                table: "UgovorOOsiguranju",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StavkaRacunaOsiguranja",
                table: "StavkaRacunaOsiguranja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Radnik",
                table: "Radnik",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RacunOsiguranja",
                table: "RacunOsiguranja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObavestenjeOIzvrsenojUplatiOsiguranja",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NacinPlacanja",
                table: "NacinPlacanja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drzava",
                table: "Drzava",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_OsiguravajuceKuce_IdOsiguravajuceKuce",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdOsiguravajuceKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_Radnik_IdRadnika",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdRadnika",
                principalTable: "Radnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_UplatnicaZaOsiguranje_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdUplatnice",
                principalTable: "UplatnicaZaOsiguranje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacunOsiguranja_NacinPlacanja_IdNacinaPlacanja",
                table: "RacunOsiguranja",
                column: "IdNacinaPlacanja",
                principalTable: "NacinPlacanja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacunOsiguranja_OsiguravajuceKuce_IdOsigKuce",
                table: "RacunOsiguranja",
                column: "IdOsigKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacunOsiguranja_Radnik_SifraRadnika",
                table: "RacunOsiguranja",
                column: "SifraRadnika",
                principalTable: "Radnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacunOsiguranja_UgovorOOsiguranju_BrUgovora",
                table: "RacunOsiguranja",
                column: "BrUgovora",
                principalTable: "UgovorOOsiguranju",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacunaOsiguranja_RacunOsiguranja_IdRacunaOsiguranja",
                table: "StavkaRacunaOsiguranja",
                column: "IdRacunaOsiguranja",
                principalTable: "RacunOsiguranja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacunaOsiguranja_RacunOsiguranja_RacunOsiguranjaId",
                table: "StavkaRacunaOsiguranja",
                column: "RacunOsiguranjaId",
                principalTable: "RacunOsiguranja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UgovorOOsiguranju_Drzava_IdDrzave",
                table: "UgovorOOsiguranju",
                column: "IdDrzave",
                principalTable: "Drzava",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UgovorOOsiguranju_OsiguravajuceKuce_IdOsigKuce",
                table: "UgovorOOsiguranju",
                column: "IdOsigKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UgovorOOsiguranju_Radnik_SifraRadnika",
                table: "UgovorOOsiguranju",
                column: "SifraRadnika",
                principalTable: "Radnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UgovorOOsiguranju_ZahtevZaOsiguranje_SifraZahteva",
                table: "UgovorOOsiguranju",
                column: "SifraZahteva",
                principalTable: "ZahtevZaOsiguranje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatnicaZaOsiguranje_Model_IdModela",
                table: "UplatnicaZaOsiguranje",
                column: "IdModela",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatnicaZaOsiguranje_RacunOsiguranja_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje",
                column: "BrRacunaOsig",
                principalTable: "RacunOsiguranja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatnicaZaOsiguranje_Radnik_SifraRadnika",
                table: "UplatnicaZaOsiguranje",
                column: "SifraRadnika",
                principalTable: "Radnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatnicaZaOsiguranje_Valuta_IdValute",
                table: "UplatnicaZaOsiguranje",
                column: "IdValute",
                principalTable: "Valuta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahtevZaOsiguranje_OsiguravajuceKuce_IdOsigKuce",
                table: "ZahtevZaOsiguranje",
                column: "IdOsigKuce",
                principalTable: "OsiguravajuceKuce",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahtevZaOsiguranje_Radnik_SifraRadnika",
                table: "ZahtevZaOsiguranje",
                column: "SifraRadnika",
                principalTable: "Radnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
