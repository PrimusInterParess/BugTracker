using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class seed_StatusPriority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
