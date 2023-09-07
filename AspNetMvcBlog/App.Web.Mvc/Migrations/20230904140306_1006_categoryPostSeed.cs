using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Web.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class _1006_categoryPostSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
