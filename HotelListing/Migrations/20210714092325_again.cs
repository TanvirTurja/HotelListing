using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class again : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UUID",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[Name] + ', ' + [ShortName]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UUID",
                table: "Countries");
        }
    }
}
