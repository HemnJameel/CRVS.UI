using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class hh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DohActive",
                table: "Dohs");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Dohs",
                newName: "DeActive");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "BrithCertificates",
                newName: "DeActive");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeActive",
                table: "Dohs",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DeActive",
                table: "BrithCertificates",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<bool>(
                name: "DohActive",
                table: "Dohs",
                type: "bit",
                nullable: true);
        }
    }
}
