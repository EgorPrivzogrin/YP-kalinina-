using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YP.Migrations
{
    /// <inheritdoc />
    public partial class lak4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "PlaceOfResidence",
                table: "Enrollee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfResidence",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
