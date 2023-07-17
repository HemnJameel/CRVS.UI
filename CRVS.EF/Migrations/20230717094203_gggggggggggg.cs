using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class gggggggggggg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NahiaCode",
                table: "Nahias");

            migrationBuilder.DropColumn(
                name: "GovernoriteCode",
                table: "Governorites");

            migrationBuilder.DropColumn(
                name: "DohCode",
                table: "Dohs");

            migrationBuilder.DropColumn(
                name: "DistrictCode",
                table: "Districts");

            migrationBuilder.AddColumn<int>(
                name: "NahiaCode",
                table: "NahiaHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GovernoriteCode",
                table: "GovernoriteHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DohCode",
                table: "DohHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictCode",
                table: "DistrictHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NahiaCode",
                table: "NahiaHistory");

            migrationBuilder.DropColumn(
                name: "GovernoriteCode",
                table: "GovernoriteHistories");

            migrationBuilder.DropColumn(
                name: "DohCode",
                table: "DohHistories");

            migrationBuilder.DropColumn(
                name: "DistrictCode",
                table: "DistrictHistories");

            migrationBuilder.AddColumn<int>(
                name: "NahiaCode",
                table: "Nahias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GovernoriteCode",
                table: "Governorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DohCode",
                table: "Dohs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictCode",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
