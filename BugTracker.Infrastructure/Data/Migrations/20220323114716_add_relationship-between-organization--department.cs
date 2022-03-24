using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_relationshipbetweenorganizationdepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments");

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

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0f39183d-d0cf-4306-ab45-7a90fcbb8488", "normal" },
                    { "40bd0cd3-46b7-4880-b221-eec30e7a8f97", "emergency" },
                    { "c90c7641-49d8-463d-8ba3-89f660de4b2b", "urgent" },
                    { "da0d3b15-b4e4-445a-bf6b-5d4cf58aa015", "low" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0cc1828d-8164-41a6-b695-b2a8484fc285", "on hold" },
                    { "127297d8-3698-470c-b875-2d01418518fe", "closed" },
                    { "5972bf40-c8bf-4ee0-a8f8-3df39466a185", "solved" },
                    { "6f826c9d-9a50-46fa-9b8e-ea353f181579", "in progress" },
                    { "f9e1618a-473c-4dc2-ad52-e15a3a90a95f", "new" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "0f39183d-d0cf-4306-ab45-7a90fcbb8488");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "40bd0cd3-46b7-4880-b221-eec30e7a8f97");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "c90c7641-49d8-463d-8ba3-89f660de4b2b");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "da0d3b15-b4e4-445a-bf6b-5d4cf58aa015");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "0cc1828d-8164-41a6-b695-b2a8484fc285");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "127297d8-3698-470c-b875-2d01418518fe");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "5972bf40-c8bf-4ee0-a8f8-3df39466a185");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "6f826c9d-9a50-46fa-9b8e-ea353f181579");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "f9e1618a-473c-4dc2-ad52-e15a3a90a95f");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
