using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "3a3258f4-3475-4c35-a1ba-b73bb7c64569", "low" },
                    { "5b2dfe70-1779-4464-afd8-f1fe4e5f8071", "normal" },
                    { "a08388d6-4cb6-4885-aa99-f1f9f6536600", "urgent" },
                    { "f9e201da-566e-45e6-bc17-36c3e98de2f7", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1a2a1a42-a328-4b27-83f7-795ee3ad871b", "in progress" },
                    { "30154e62-20bb-40c5-b349-fe7cd4177ea6", "closed" },
                    { "38f83cee-9af0-4d77-85b3-6f0e0e967f1d", "solved" },
                    { "80630ba3-8992-437f-86cd-ca8bb2671a80", "new" },
                    { "f953e7f8-4d54-4a12-813b-d5796dc3cf74", "on hold" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "3a3258f4-3475-4c35-a1ba-b73bb7c64569");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "5b2dfe70-1779-4464-afd8-f1fe4e5f8071");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "a08388d6-4cb6-4885-aa99-f1f9f6536600");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "f9e201da-566e-45e6-bc17-36c3e98de2f7");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "1a2a1a42-a328-4b27-83f7-795ee3ad871b");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "30154e62-20bb-40c5-b349-fe7cd4177ea6");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "38f83cee-9af0-4d77-85b3-6f0e0e967f1d");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "80630ba3-8992-437f-86cd-ca8bb2671a80");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "f953e7f8-4d54-4a12-813b-d5796dc3cf74");
        }
    }
}
