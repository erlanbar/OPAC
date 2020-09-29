using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class notulen030820 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlamatInstansi",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instansi",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NIK",
                table: "User",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "PendidikanTerakhir",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocmedToken",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitKerja",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlamatInstansi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Instansi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NIK",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PendidikanTerakhir",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SocmedToken",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UnitKerja",
                table: "User");
        }
    }
}
