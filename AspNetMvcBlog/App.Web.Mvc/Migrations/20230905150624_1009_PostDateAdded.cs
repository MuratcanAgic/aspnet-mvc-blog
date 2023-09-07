using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Web.Mvc.Migrations
{
	/// <inheritdoc />
	public partial class _1009_PostDateAdded : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<DateTime>(
					name: "PostDate",
					table: "Post",
					type: "datetime2",
					nullable: false,
					defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.UpdateData(
					table: "Post",
					keyColumn: "Id",
					keyValue: 1,
					column: "PostDate",
					value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.UpdateData(
					table: "Post",
					keyColumn: "Id",
					keyValue: 2,
					column: "PostDate",
					value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
					name: "PostDate",
					table: "Post");
		}
	}
}
