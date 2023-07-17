using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class j : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NahiaHistory",
                table: "NahiaHistory");

            migrationBuilder.RenameTable(
                name: "NahiaHistory",
                newName: "nahiaHistories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nahiaHistories",
                table: "nahiaHistories",
                column: "NahiaHistoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_nahiaHistories",
                table: "nahiaHistories");

            migrationBuilder.RenameTable(
                name: "nahiaHistories",
                newName: "NahiaHistory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NahiaHistory",
                table: "NahiaHistory",
                column: "NahiaHistoryId");
        }
    }
}
