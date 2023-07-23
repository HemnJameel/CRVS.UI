using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class hhhjjjj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted2",
                table: "Nahias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted3",
                table: "Nahias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted2",
                table: "nahiaHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted3",
                table: "nahiaHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted2",
                table: "Governorites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted3",
                table: "Governorites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted2",
                table: "Dohs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted3",
                table: "Dohs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted2",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted3",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted2",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted3",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted2",
                table: "Nahias");

            migrationBuilder.DropColumn(
                name: "IsDeleted3",
                table: "Nahias");

            migrationBuilder.DropColumn(
                name: "IsDeleted2",
                table: "nahiaHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted3",
                table: "nahiaHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted2",
                table: "Governorites");

            migrationBuilder.DropColumn(
                name: "IsDeleted3",
                table: "Governorites");

            migrationBuilder.DropColumn(
                name: "IsDeleted2",
                table: "Dohs");

            migrationBuilder.DropColumn(
                name: "IsDeleted3",
                table: "Dohs");

            migrationBuilder.DropColumn(
                name: "IsDeleted2",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted3",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "IsDeleted2",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "IsDeleted3",
                table: "BrithCertificates");
        }
    }
}
