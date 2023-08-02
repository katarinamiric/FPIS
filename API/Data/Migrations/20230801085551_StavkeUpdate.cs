using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class StavkeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkeRacunaOsiguranja_RacuniOsiguranja_RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja");

            migrationBuilder.DropIndex(
                name: "IX_StavkeRacunaOsiguranja_RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja");

            migrationBuilder.DropColumn(
                name: "RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkeRacunaOsiguranja_RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja",
                column: "RacunOsiguranjaId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeRacunaOsiguranja_RacuniOsiguranja_RacunOsiguranjaId",
                table: "StavkeRacunaOsiguranja",
                column: "RacunOsiguranjaId",
                principalTable: "RacuniOsiguranja",
                principalColumn: "Id");
        }
    }
}
