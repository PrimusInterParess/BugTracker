using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_relationshipbetweenorganizationdepartment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
