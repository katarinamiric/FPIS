using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class RacunUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_OsiguravajucaKuca_IdOsigKuce",
                table: "RacuniOsiguranja");

            migrationBuilder.AlterColumn<int>(
                name: "IdOsigKuce",
                table: "RacuniOsiguranja",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_OsiguravajucaKuca_IdOsigKuce",
                table: "RacuniOsiguranja",
                column: "IdOsigKuce",
                principalTable: "OsiguravajucaKuca",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_OsiguravajucaKuca_IdOsigKuce",
                table: "RacuniOsiguranja");

            migrationBuilder.AlterColumn<int>(
                name: "IdOsigKuce",
                table: "RacuniOsiguranja",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_OsiguravajucaKuca_IdOsigKuce",
                table: "RacuniOsiguranja",
                column: "IdOsigKuce",
                principalTable: "OsiguravajucaKuca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
