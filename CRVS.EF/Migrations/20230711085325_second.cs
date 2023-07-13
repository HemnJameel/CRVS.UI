using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrithCertificates",
                columns: table => new
                {
                    BrithCertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertifateNo = table.Column<int>(type: "int", nullable: false),
                    HealthID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrithCertificates", x => x.BrithCertificateId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrithCertificates");
        }
    }
}
