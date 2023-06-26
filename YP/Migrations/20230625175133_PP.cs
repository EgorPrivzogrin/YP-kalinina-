using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YP.Migrations
{
    /// <inheritdoc />
    public partial class PP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_Speciality_SpecialityId",
                table: "Enrollee");

            migrationBuilder.DropTable(
                name: "Speciality");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_SpecialityId",
                table: "Enrollee");

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "Enrollee");

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionСode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_SpecialityId",
                table: "Enrollee",
                column: "SpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_Speciality_SpecialityId",
                table: "Enrollee",
                column: "SpecialityId",
                principalTable: "Speciality",
                principalColumn: "Id");
        }
    }
}
