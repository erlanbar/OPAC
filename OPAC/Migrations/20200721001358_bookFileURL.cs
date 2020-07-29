using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class bookFileURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPublished",
                table: "Books",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FileURL",
                table: "Books",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileURL",
                table: "Books");

            migrationBuilder.AlterColumn<short>(
                name: "IsPublished",
                table: "Books",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
