using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YP.Migrations
{
    /// <inheritdoc />
    public partial class lak5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shils",
                table: "Enrollee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shils",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
