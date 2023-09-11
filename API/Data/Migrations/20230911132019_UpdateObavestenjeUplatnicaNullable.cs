using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateObavestenjeUplatnicaNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_UplatnicaZaOsiguranje_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.AlterColumn<int>(
                name: "IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_UplatnicaZaOsiguranje_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdUplatnice",
                principalTable: "UplatnicaZaOsiguranje",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_UplatnicaZaOsiguranje_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja");

            migrationBuilder.AlterColumn<int>(
                name: "IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavestenjeOIzvrsenojUplatiOsiguranja_UplatnicaZaOsiguranje_IdUplatnice",
                table: "ObavestenjeOIzvrsenojUplatiOsiguranja",
                column: "IdUplatnice",
                principalTable: "UplatnicaZaOsiguranje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
