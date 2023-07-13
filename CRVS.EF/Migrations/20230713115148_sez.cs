using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class sez : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "governarites");

            migrationBuilder.RenameColumn(
                name: "GovernariteId",
                table: "Nahias",
                newName: "GovernoriteId");

            migrationBuilder.RenameColumn(
                name: "GovernariteId",
                table: "HealthInstitutions",
                newName: "GovernoriteId");

            migrationBuilder.RenameColumn(
                name: "GovernariteId",
                table: "Dohs",
                newName: "GovernoriteId");

            migrationBuilder.RenameColumn(
                name: "GovernariteId",
                table: "Districts",
                newName: "GovernoriteId");

            migrationBuilder.CreateTable(
                name: "Governorites",
                columns: table => new
                {
                    GovernoriteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernoriteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorites", x => x.GovernoriteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Governorites");

            migrationBuilder.RenameColumn(
                name: "GovernoriteId",
                table: "Nahias",
                newName: "GovernariteId");

            migrationBuilder.RenameColumn(
                name: "GovernoriteId",
                table: "HealthInstitutions",
                newName: "GovernariteId");

            migrationBuilder.RenameColumn(
                name: "GovernoriteId",
                table: "Dohs",
                newName: "GovernariteId");

            migrationBuilder.RenameColumn(
                name: "GovernoriteId",
                table: "Districts",
                newName: "GovernariteId");

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
        }
    }
}
