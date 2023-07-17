using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class g : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NahiaType",
                table: "NahiaHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GovernoriteType",
                table: "GovernoriteHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DohType",
                table: "DohHistories",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NahiaType",
                table: "NahiaHistory");

            migrationBuilder.DropColumn(
                name: "GovernoriteType",
                table: "GovernoriteHistories");

            migrationBuilder.DropColumn(
                name: "DohType",
                table: "DohHistories");
        }
    }
}
