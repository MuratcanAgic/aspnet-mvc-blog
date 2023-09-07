using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Web.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class _1008_PostImageSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { 1, "../images/slider/slider1.jpg", 1 },
                    { 2, "../images/slider/slider2.jpg", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
