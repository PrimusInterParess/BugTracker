using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class change_onDeleteAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_AspNetUsers_UserId",
                table: "Administrators");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "08ae5d28-abf1-4497-8205-fe09222904a6");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "24f8a33c-434f-4f6c-8020-38a3aa0645f7");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "41b63026-eb0a-4eca-a894-7a698b6e924d");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "5c68293c-0680-4bcd-afd3-f9e6b9cefc79");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "177f2c3e-ed4d-41b8-bc71-8a800a3aac38");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "2bd6d41b-3bd8-4741-93ce-de634ef14dd1");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "488444eb-6bad-4e8d-952f-35380756cc0d");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "d5bee7c7-32d6-4757-8d46-dc730fea96aa");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "eae421ba-256f-4755-9c59-beb9682f589f");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "6739d464-71c7-45c9-8a7c-496bb8d3002b", "urgent" },
                    { "a028f9dc-7925-46a1-9eea-438710e3318c", "normal" },
                    { "fb226cca-bbef-416e-9111-2bd48d9ab1e3", "low" },
                    { "ffda0fae-b608-44e7-bad4-7caea50fdbc6", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "84725746-e12e-47b3-8c5c-5f839fd32d37", "solved" },
                    { "8631f429-ebdc-4a46-b3b6-1a6c7b3dcb30", "closed" },
                    { "c243017d-d85c-412b-9549-eb7f7b35c822", "new" },
                    { "cfcbeec1-a1b6-4a70-b3f7-24d3eba055ea", "on hold" },
                    { "f3e6b6f5-98d8-41d5-932f-dcc53d31739a", "in progress" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_AspNetUsers_UserId",
                table: "Administrators",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_AspNetUsers_UserId",
                table: "Administrators");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "6739d464-71c7-45c9-8a7c-496bb8d3002b");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "a028f9dc-7925-46a1-9eea-438710e3318c");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "fb226cca-bbef-416e-9111-2bd48d9ab1e3");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "ffda0fae-b608-44e7-bad4-7caea50fdbc6");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "84725746-e12e-47b3-8c5c-5f839fd32d37");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "8631f429-ebdc-4a46-b3b6-1a6c7b3dcb30");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c243017d-d85c-412b-9549-eb7f7b35c822");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "cfcbeec1-a1b6-4a70-b3f7-24d3eba055ea");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "f3e6b6f5-98d8-41d5-932f-dcc53d31739a");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "08ae5d28-abf1-4497-8205-fe09222904a6", "low" },
                    { "24f8a33c-434f-4f6c-8020-38a3aa0645f7", "urgent" },
                    { "41b63026-eb0a-4eca-a894-7a698b6e924d", "normal" },
                    { "5c68293c-0680-4bcd-afd3-f9e6b9cefc79", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "177f2c3e-ed4d-41b8-bc71-8a800a3aac38", "solved" },
                    { "2bd6d41b-3bd8-4741-93ce-de634ef14dd1", "in progress" },
                    { "488444eb-6bad-4e8d-952f-35380756cc0d", "closed" },
                    { "d5bee7c7-32d6-4757-8d46-dc730fea96aa", "on hold" },
                    { "eae421ba-256f-4755-9c59-beb9682f589f", "new" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_AspNetUsers_UserId",
                table: "Administrators",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
