using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class userPekerjaanAndAlamatRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropColumn(
            //     name: "AlamatInstansi",
            //     table: "User");

            // migrationBuilder.DropColumn(
            //     name: "Instansi",
            //     table: "User");

            // migrationBuilder.DropColumn(
            //     name: "UnitKerja",
            //     table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "PendidikanTerakhir",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alamat",
                table: "User",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Pekerjaan",
                table: "User",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alamat",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Pekerjaan",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "PendidikanTerakhir",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "AlamatInstansi",
                table: "User",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instansi",
                table: "User",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitKerja",
                table: "User",
                type: "text",
                nullable: true);
        }
    }
}
