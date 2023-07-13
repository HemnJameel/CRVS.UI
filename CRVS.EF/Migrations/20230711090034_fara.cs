using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class fara : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertifateNo",
                table: "BrithCertificates");

            migrationBuilder.AddColumn<string>(
                name: "CertificateNo",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificateNo",
                table: "BrithCertificates");

            migrationBuilder.AddColumn<int>(
                name: "CertifateNo",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
