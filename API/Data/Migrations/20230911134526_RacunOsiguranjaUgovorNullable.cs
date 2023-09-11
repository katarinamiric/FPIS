using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class RacunOsiguranjaUgovorNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_UgovorOOsiguranju_BrUgovora",
                table: "RacuniOsiguranja");

            migrationBuilder.AlterColumn<int>(
                name: "BrUgovora",
                table: "RacuniOsiguranja",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_UgovorOOsiguranju_BrUgovora",
                table: "RacuniOsiguranja",
                column: "BrUgovora",
                principalTable: "UgovorOOsiguranju",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RacuniOsiguranja_UgovorOOsiguranju_BrUgovora",
                table: "RacuniOsiguranja");

            migrationBuilder.AlterColumn<int>(
                name: "BrUgovora",
                table: "RacuniOsiguranja",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RacuniOsiguranja_UgovorOOsiguranju_BrUgovora",
                table: "RacuniOsiguranja",
                column: "BrUgovora",
                principalTable: "UgovorOOsiguranju",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
