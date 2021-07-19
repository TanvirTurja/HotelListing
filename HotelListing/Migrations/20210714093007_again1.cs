using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class again1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UUID",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "'UID' + Right('00000000'+ CAST(ID AS VARCHAR(8)),8) PERSISTED",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComputedColumnSql: "[Name] + ', ' + [ShortName]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UUID",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[Name] + ', ' + [ShortName]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComputedColumnSql: "'UID' + Right('00000000'+ CAST(ID AS VARCHAR(8)),8) PERSISTED");
        }
    }
}
