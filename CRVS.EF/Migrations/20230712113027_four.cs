using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disables",
                columns: table => new
                {
                    DisableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisableName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disables", x => x.DisableId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernariteId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "Dohs",
                columns: table => new
                {
                    DohId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DohName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernariteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dohs", x => x.DohId);
                });

            migrationBuilder.CreateTable(
                name: "facilityTypes",
                columns: table => new
                {
                    FacilityTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facilityTypes", x => x.FacilityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "governarites",
                columns: table => new
                {
                    GovernariteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernariteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governarites", x => x.GovernariteId);
                });

            migrationBuilder.CreateTable(
                name: "HealthInstitutions",
                columns: table => new
                {
                    HealthInstitutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthInstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernariteId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false),
                    FacilityTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInstitutions", x => x.HealthInstitutionId);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Nahias",
                columns: table => new
                {
                    NahiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NahiaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernariteId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nahias", x => x.NahiaId);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    ReligionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.ReligionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disables");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Dohs");

            migrationBuilder.DropTable(
                name: "facilityTypes");

            migrationBuilder.DropTable(
                name: "governarites");

            migrationBuilder.DropTable(
                name: "HealthInstitutions");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "Nahias");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Religions");
        }
    }
}
