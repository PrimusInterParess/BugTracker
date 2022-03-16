using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_BugtitleProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "3ff12629-78ec-46fe-98dd-477292f9a207");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "8c39feab-138a-4df3-8481-7e4562134765");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "f1dc1f37-7a57-4e61-95cb-becf352214b7");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "f82847ff-de0a-4f22-b385-448297b99788");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "1a274a82-ec16-430c-bf6c-e3b966d95a98");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "1d61373b-a2dc-4d89-a890-6848c83e54a9");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "974b31a8-fb67-4214-832e-946eee55a2c2");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "db54fae1-65df-414c-baa6-ffb9c7ab9a55");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "e3b788bf-4777-4fc4-8db0-587394d2fb52");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Bugs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "18a261b4-7610-4bc1-b30c-df8821b9ca8a", "low" },
                    { "1e433816-cc0b-423b-9a32-fa018ff3d98d", "normal" },
                    { "79ff6b44-8df8-45d6-8770-0ec327a73caa", "urgent" },
                    { "cacafdc9-5402-4df0-b44e-6e9d3533ea76", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "066fec01-6277-4760-b221-7443f1aa7bba", "solved" },
                    { "59b5ff24-a219-4b8e-843b-abe55f7650cd", "in progress" },
                    { "6e16cafc-b7b6-4502-838a-60686f0a4526", "on hold" },
                    { "a8230807-c702-43be-995c-49faee7d2f2e", "new" },
                    { "de5f8bf9-903f-48c8-9a6a-a8796b01a21d", "closed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "18a261b4-7610-4bc1-b30c-df8821b9ca8a");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "1e433816-cc0b-423b-9a32-fa018ff3d98d");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "79ff6b44-8df8-45d6-8770-0ec327a73caa");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "cacafdc9-5402-4df0-b44e-6e9d3533ea76");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "066fec01-6277-4760-b221-7443f1aa7bba");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "59b5ff24-a219-4b8e-843b-abe55f7650cd");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "6e16cafc-b7b6-4502-838a-60686f0a4526");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "a8230807-c702-43be-995c-49faee7d2f2e");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "de5f8bf9-903f-48c8-9a6a-a8796b01a21d");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Bugs");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "3ff12629-78ec-46fe-98dd-477292f9a207", "low" },
                    { "8c39feab-138a-4df3-8481-7e4562134765", "normal" },
                    { "f1dc1f37-7a57-4e61-95cb-becf352214b7", "emergency" },
                    { "f82847ff-de0a-4f22-b385-448297b99788", "urgent" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1a274a82-ec16-430c-bf6c-e3b966d95a98", "on hold" },
                    { "1d61373b-a2dc-4d89-a890-6848c83e54a9", "closed" },
                    { "974b31a8-fb67-4214-832e-946eee55a2c2", "in progress" },
                    { "db54fae1-65df-414c-baa6-ffb9c7ab9a55", "solved" },
                    { "e3b788bf-4777-4fc4-8db0-587394d2fb52", "new" }
                });
        }
    }
}
