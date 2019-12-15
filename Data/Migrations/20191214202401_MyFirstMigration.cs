using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerApp.Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a61d1c4c-c8cb-4a7f-be10-e938c7ce2a86", "0531fe48-dc2d-4efc-9de0-cf6ff5c06f37", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3b787d1-29d0-4177-bf14-1fe68296779f", "2740a7b7-85d4-4845-8aaa-f0361771126f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a61d1c4c-c8cb-4a7f-be10-e938c7ce2a86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3b787d1-29d0-4177-bf14-1fe68296779f");
        }
    }
}
