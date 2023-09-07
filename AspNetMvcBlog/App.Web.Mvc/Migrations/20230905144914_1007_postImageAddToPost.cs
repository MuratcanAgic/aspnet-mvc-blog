using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Web.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class _1007_postImageAddToPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage");

            migrationBuilder.CreateIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage",
                column: "PostId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage");

            migrationBuilder.CreateIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage",
                column: "PostId");
        }
    }
}
