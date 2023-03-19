using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeProjectAJAX1.Migrations
{
    public partial class userupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileIMageFileName",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValue: "no-image.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileIMageFileName",
                table: "Users");
        }
    }
}
