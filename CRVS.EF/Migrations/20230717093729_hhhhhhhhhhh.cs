using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class hhhhhhhhhhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
