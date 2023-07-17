using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class hidtory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistrictHistories",
                columns: table => new
                {
                    DistrictHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictHistoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictHistorydate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictHistories", x => x.DistrictHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "DohHistories",
                columns: table => new
                {
                    DohHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DohHistoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DohHistorydate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DohHistories", x => x.DohHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "GovernoriteHistories",
                columns: table => new
                {
                    GovernoriteHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernoriteHistoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernoriteHistorydate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovernoriteHistories", x => x.GovernoriteHistoryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistrictHistories");

            migrationBuilder.DropTable(
                name: "DohHistories");

            migrationBuilder.DropTable(
                name: "GovernoriteHistories");
        }
    }
}
