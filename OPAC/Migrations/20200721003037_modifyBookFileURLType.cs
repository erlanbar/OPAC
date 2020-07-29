using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class modifyBookFileURLType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileURL",
                table: "Books",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "FileURL",
                table: "Books",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
