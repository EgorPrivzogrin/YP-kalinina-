using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YP.Migrations
{
    /// <inheritdoc />
    public partial class lak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_Certificate_CertificateId",
                table: "Enrollee");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_Citizenship_CitizenshipId",
                table: "Enrollee");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_Disability_DisabilityId",
                table: "Enrollee");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_District_DistrictId",
                table: "Enrollee");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_Education_EducationId",
                table: "Enrollee");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_PlaceOfResidence_PlaceOfResidenceId",
                table: "Enrollee");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollee_Ward_WardId",
                table: "Enrollee");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Citizenship");

            migrationBuilder.DropTable(
                name: "Disability");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "PlaceOfResidence");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_CertificateId",
                table: "Enrollee");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_CitizenshipId",
                table: "Enrollee");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_DisabilityId",
                table: "Enrollee");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_DistrictId",
                table: "Enrollee");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_EducationId",
                table: "Enrollee");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_PlaceOfResidenceId",
                table: "Enrollee");

            migrationBuilder.DropIndex(
                name: "IX_Enrollee_WardId",
                table: "Enrollee");

            migrationBuilder.AddColumn<string>(
                name: "Certificate",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Citizenship",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Disability",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Education",
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

            migrationBuilder.AddColumn<string>(
                name: "Ward",
                table: "Enrollee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Certificate",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "Citizenship",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "Disability",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "PlaceOfResidence",
                table: "Enrollee");

            migrationBuilder.DropColumn(
                name: "Ward",
                table: "Enrollee");

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvarageScore = table.Column<double>(type: "float", nullable: false),
                    Original = table.Column<bool>(type: "bit", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citizenship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenship", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalEducation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    After11School = table.Column<bool>(type: "bit", nullable: false),
                    After9School = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceOfResidence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceOfResidence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_CertificateId",
                table: "Enrollee",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_CitizenshipId",
                table: "Enrollee",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_DisabilityId",
                table: "Enrollee",
                column: "DisabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_DistrictId",
                table: "Enrollee",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_EducationId",
                table: "Enrollee",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_PlaceOfResidenceId",
                table: "Enrollee",
                column: "PlaceOfResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_WardId",
                table: "Enrollee",
                column: "WardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_Certificate_CertificateId",
                table: "Enrollee",
                column: "CertificateId",
                principalTable: "Certificate",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_Citizenship_CitizenshipId",
                table: "Enrollee",
                column: "CitizenshipId",
                principalTable: "Citizenship",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_Disability_DisabilityId",
                table: "Enrollee",
                column: "DisabilityId",
                principalTable: "Disability",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_District_DistrictId",
                table: "Enrollee",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_Education_EducationId",
                table: "Enrollee",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_PlaceOfResidence_PlaceOfResidenceId",
                table: "Enrollee",
                column: "PlaceOfResidenceId",
                principalTable: "PlaceOfResidence",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollee_Ward_WardId",
                table: "Enrollee",
                column: "WardId",
                principalTable: "Ward",
                principalColumn: "Id");
        }
    }
}
