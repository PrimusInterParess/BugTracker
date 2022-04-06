using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class alterTable_organizationemployeesprojects1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "OrganizationId",
                table: "Projects",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrganizationId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "293ddb24-106c-474d-be0f-7b7897da230c", "urgent" },
                    { "530eb59b-ae78-40ba-aa57-fb35231566fd", "normal" },
                    { "6f0d0019-cbbe-44bf-8cfe-0ff3db80d798", "emergency" },
                    { "d4cc6aa3-3e52-4a42-b7b4-a81190aa678c", "low" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0bed5549-86ef-44fd-bacf-1835f1e0a844", "on hold" },
                    { "478611d0-e2eb-459e-8add-6bbc5108e9de", "in progress" },
                    { "569e8b0c-e61a-4bc9-a330-28419e854589", "solved" },
                    { "64b19fa5-9839-400e-bfa0-d0f396d0776e", "new" },
                    { "990bbf62-4848-40be-b935-c4f6092c2de6", "closed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OrganizationId",
                table: "Projects",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OrganizationId",
                table: "Employees",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Organizations_OrganizationId",
                table: "Employees",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Organizations_OrganizationId",
                table: "Projects",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Organizations_OrganizationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Organizations_OrganizationId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_OrganizationId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_OrganizationId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "293ddb24-106c-474d-be0f-7b7897da230c");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "530eb59b-ae78-40ba-aa57-fb35231566fd");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "6f0d0019-cbbe-44bf-8cfe-0ff3db80d798");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "d4cc6aa3-3e52-4a42-b7b4-a81190aa678c");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "0bed5549-86ef-44fd-bacf-1835f1e0a844");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "478611d0-e2eb-459e-8add-6bbc5108e9de");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "569e8b0c-e61a-4bc9-a330-28419e854589");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "64b19fa5-9839-400e-bfa0-d0f396d0776e");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "990bbf62-4848-40be-b935-c4f6092c2de6");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Employees");

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
        }
    }
}
