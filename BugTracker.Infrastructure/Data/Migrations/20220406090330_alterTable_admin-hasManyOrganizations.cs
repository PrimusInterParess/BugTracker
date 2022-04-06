using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class alterTable_adminhasManyOrganizations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Organizations_AdministratiorId",
                table: "Organizations");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "12148187-706f-4f12-b9ee-dc332ea94215");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "825874ea-55df-46ca-a0ae-5bdc220f1a23");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "859435a7-6fff-4690-855d-9e9278046ed5");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "86e585b9-f31a-473a-945b-0e4ff68be493");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "291631ab-c704-4934-ac43-7f50f191a2da");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "2f54f0b4-cc0b-419a-b757-9b0eab5abc38");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "cbaacce5-9e11-48fb-b6a6-366ab91c6e99");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "d4b814c1-5360-4555-9d93-2ae6921e8634");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "d9d25a1d-6cad-432e-8eaf-f59693d6c5dc");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Administrators");

            migrationBuilder.AlterColumn<string>(
                name: "StreetName",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "01d956a9-29b2-4efe-a33c-5e0085bde2b0", "low" },
                    { "2396890b-47df-4220-898b-65ad1eedaaa2", "emergency" },
                    { "8220e6d4-8c4f-4cc5-aa7e-f045fcf26b2c", "urgent" },
                    { "b973598d-d793-4bbb-8f99-04019267cc35", "normal" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "10e4123e-1f2c-45e3-9eef-01d7e04e98e7", "solved" },
                    { "1b9bbcb8-6ceb-4fb6-92e7-9ef7d860e33a", "closed" },
                    { "30765cc8-2ee6-46f6-8036-3746e14a2ee0", "on hold" },
                    { "c6a2f09c-91d0-4d09-8841-815d60469630", "new" },
                    { "f8c7da41-9234-453e-be3b-c91d4fec2edb", "in progress" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AdministratiorId",
                table: "Organizations",
                column: "AdministratiorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Organizations_AdministratiorId",
                table: "Organizations");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "01d956a9-29b2-4efe-a33c-5e0085bde2b0");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "2396890b-47df-4220-898b-65ad1eedaaa2");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "8220e6d4-8c4f-4cc5-aa7e-f045fcf26b2c");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "b973598d-d793-4bbb-8f99-04019267cc35");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "10e4123e-1f2c-45e3-9eef-01d7e04e98e7");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "1b9bbcb8-6ceb-4fb6-92e7-9ef7d860e33a");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "30765cc8-2ee6-46f6-8036-3746e14a2ee0");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c6a2f09c-91d0-4d09-8841-815d60469630");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "f8c7da41-9234-453e-be3b-c91d4fec2edb");

            migrationBuilder.AlterColumn<string>(
                name: "StreetName",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "OrganizationId",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "12148187-706f-4f12-b9ee-dc332ea94215", "normal" },
                    { "825874ea-55df-46ca-a0ae-5bdc220f1a23", "urgent" },
                    { "859435a7-6fff-4690-855d-9e9278046ed5", "emergency" },
                    { "86e585b9-f31a-473a-945b-0e4ff68be493", "low" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "291631ab-c704-4934-ac43-7f50f191a2da", "on hold" },
                    { "2f54f0b4-cc0b-419a-b757-9b0eab5abc38", "in progress" },
                    { "cbaacce5-9e11-48fb-b6a6-366ab91c6e99", "new" },
                    { "d4b814c1-5360-4555-9d93-2ae6921e8634", "closed" },
                    { "d9d25a1d-6cad-432e-8eaf-f59693d6c5dc", "solved" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AdministratiorId",
                table: "Organizations",
                column: "AdministratiorId",
                unique: true);
        }
    }
}
