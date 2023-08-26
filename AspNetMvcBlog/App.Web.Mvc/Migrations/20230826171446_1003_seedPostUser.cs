using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Web.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class _1003_seedPostUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[,]
                {
                    { 1, "KibisTokmak@gmail.com", "Kibariye", "Tokmakçı", "341582", "Tokmak" },
                    { 2, "Zekis@hotmail.com", "Zeki", "UçaktanAtlayan", "319482", "Müren" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "PostContext", "PostTitle", "UserId" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce elementum, enim et dapibus efficitur, augue augue blandit ex, et scelerisque orci felis quis massa. Donec viverra risus augue, ac auctor nisl ultrices id. Aliquam luctus mauris vitae laoreet ullamcorper. Mauris suscipit nisl sapien, sed auctor arcu feugiat vel. Integer rhoncus, diam sed consectetur dignissim, elit nibh eleifend eros, et eleifend risus augue id ante. Aenean eu risus scelerisque, mollis nulla at, finibus felis. Nulla blandit ipsum eget leo eleifend lobortis. Nulla in fringilla sem. Phasellus accumsan vitae tortor non tincidunt. Sed convallis, augue sit amet aliquet tempor, eros eros fringilla libero, ultrices placerat urna augue eu nisl. Praesent suscipit viverra nulla, sed condimentum ante iaculis eget. Nam auctor faucibus metus, non gravida leo pellentesque et.", "Lorem ipsum dolor sit amet.", 1 },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vulputate id nisi tristique ullamcorper. Vestibulum aliquam ipsum ac diam lacinia, vitae posuere urna efficitur. Cras tempus quam ut condimentum iaculis. Donec euismod enim et tristique feugiat. Suspendisse non malesuada eros. Nulla id enim sit amet orci fringilla interdum. Etiam ultricies pharetra elit, eget vulputate odio. Fusce facilisis in lacus id lacinia. In ex lacus, convallis nec sapien non, placerat consectetur ipsum. Quisque cursus ligula id ullamcorper sagittis. Vivamus ultricies mollis augue. Nunc vel erat vitae purus vestibulum egestas.", "Consectetur adipiscing.", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
