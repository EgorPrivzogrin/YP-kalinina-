using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YP.Migrations
{
    /// <inheritdoc />
    public partial class lak3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Certificate",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "CertificateId",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "CitizenshipId",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "DisabilityId",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "PlaceOfResidenceId",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Enrollee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Certificate",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CertificateId",
                table: "Enrollee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CitizenshipId",
                table: "Enrollee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisabilityId",
                table: "Enrollee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Enrollee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Enrollee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaceOfResidenceId",
                table: "Enrollee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Enrollee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                table: "Enrollee",
                type: "int",
                nullable: true);
        }
    }
}
