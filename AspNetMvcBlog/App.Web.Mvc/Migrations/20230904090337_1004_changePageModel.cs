using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Web.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class _1004_changePageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Page_Post_PostId",
                table: "Page");

            migrationBuilder.DropIndex(
                name: "IX_Page_PostId",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Page");

            migrationBuilder.AddColumn<string>(
                name: "PageContext",
                table: "Page",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "Page",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageContext",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "Page");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Page",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Page_PostId",
                table: "Page",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Page_Post_PostId",
                table: "Page",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
