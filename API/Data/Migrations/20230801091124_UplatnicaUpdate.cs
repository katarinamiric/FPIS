using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UplatnicaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UplatnicaZaOsiguranje_RacuniOsiguranja_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje");

            migrationBuilder.AlterColumn<int>(
                name: "BrRacunaOsig",
                table: "UplatnicaZaOsiguranje",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_UplatnicaZaOsiguranje_RacuniOsiguranja_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje",
                column: "BrRacunaOsig",
                principalTable: "RacuniOsiguranja",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UplatnicaZaOsiguranje_RacuniOsiguranja_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje");

            migrationBuilder.AlterColumn<int>(
                name: "BrRacunaOsig",
                table: "UplatnicaZaOsiguranje",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UplatnicaZaOsiguranje_RacuniOsiguranja_BrRacunaOsig",
                table: "UplatnicaZaOsiguranje",
                column: "BrRacunaOsig",
                principalTable: "RacuniOsiguranja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
