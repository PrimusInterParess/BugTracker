using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_relationshipbetweenorganizationdepartment23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "554d0473-c63a-40b7-bc25-e181787174c7");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "aff2bed6-5653-4da0-8fb8-54fef8a000a8");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "cf346e5b-9667-468c-b179-5c40e894a291");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "efb355bc-dbdc-4638-87df-5f868966f47b");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "4fd680b2-8abc-4aba-b7ed-d3aed88f8c39");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "74f63900-7a8f-42d5-a2d6-69a2f6abbdbf");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "9948fda6-88c1-4411-92e9-09cd5a7a6419");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "bd98084d-a4e0-4f1d-8b0d-718df17279e3");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "e9c6d59f-25ff-427e-9329-9a6b84dc1195");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0048def8-ce07-4152-b655-d6cbe2fe1b7e", "low" },
                    { "65251bb5-b296-4f0b-9911-cf7587a6031d", "urgent" },
                    { "6894279d-be66-4e9b-bea9-e1d31a8275d0", "normal" },
                    { "eda748c4-eddd-4be9-8a59-fa360a66063c", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2ee5ba0a-5d4f-4452-b659-31ec347b5ecc", "in progress" },
                    { "7e8df974-343e-47f8-88fd-87672c813524", "solved" },
                    { "9842a68c-e461-4f85-a8c4-20dea8ea3396", "closed" },
                    { "ae3e585c-0713-4797-806b-b07b638609c8", "new" },
                    { "b2ea4f7f-3cdf-4257-a49e-2b1cb898837c", "on hold" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "0048def8-ce07-4152-b655-d6cbe2fe1b7e");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "65251bb5-b296-4f0b-9911-cf7587a6031d");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "6894279d-be66-4e9b-bea9-e1d31a8275d0");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "eda748c4-eddd-4be9-8a59-fa360a66063c");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "2ee5ba0a-5d4f-4452-b659-31ec347b5ecc");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "7e8df974-343e-47f8-88fd-87672c813524");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "9842a68c-e461-4f85-a8c4-20dea8ea3396");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "ae3e585c-0713-4797-806b-b07b638609c8");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "b2ea4f7f-3cdf-4257-a49e-2b1cb898837c");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "554d0473-c63a-40b7-bc25-e181787174c7", "normal" },
                    { "aff2bed6-5653-4da0-8fb8-54fef8a000a8", "emergency" },
                    { "cf346e5b-9667-468c-b179-5c40e894a291", "low" },
                    { "efb355bc-dbdc-4638-87df-5f868966f47b", "urgent" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4fd680b2-8abc-4aba-b7ed-d3aed88f8c39", "new" },
                    { "74f63900-7a8f-42d5-a2d6-69a2f6abbdbf", "on hold" },
                    { "9948fda6-88c1-4411-92e9-09cd5a7a6419", "closed" },
                    { "bd98084d-a4e0-4f1d-8b0d-718df17279e3", "solved" },
                    { "e9c6d59f-25ff-427e-9329-9a6b84dc1195", "in progress" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
