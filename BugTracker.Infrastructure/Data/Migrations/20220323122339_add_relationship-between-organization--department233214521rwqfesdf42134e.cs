using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_relationshipbetweenorganizationdepartment233214521rwqfesdf42134e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "42a7ea44-5563-433d-9171-5a4dfddf1fc2", "urgent" },
                    { "aceea036-1e1a-4471-99ec-6dd1a87d5335", "emergency" },
                    { "afc31a0b-ab9e-4d19-99d2-6174ea0fad07", "low" },
                    { "afdee6c1-0702-432b-9017-05d35b00025b", "normal" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2568c6c7-0711-4d48-8e01-c1eb6491f256", "solved" },
                    { "64faa8b7-4a13-4b47-ba3a-388f8e590bba", "new" },
                    { "a7715bb0-4ab3-4eaf-91eb-e49ed1701b24", "on hold" },
                    { "b31b0314-a35e-4003-ae00-91eab7eab3c2", "in progress" },
                    { "f934da16-791a-427b-9929-763635627122", "closed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "42a7ea44-5563-433d-9171-5a4dfddf1fc2");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "aceea036-1e1a-4471-99ec-6dd1a87d5335");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "afc31a0b-ab9e-4d19-99d2-6174ea0fad07");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "afdee6c1-0702-432b-9017-05d35b00025b");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "2568c6c7-0711-4d48-8e01-c1eb6491f256");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "64faa8b7-4a13-4b47-ba3a-388f8e590bba");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "a7715bb0-4ab3-4eaf-91eb-e49ed1701b24");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "b31b0314-a35e-4003-ae00-91eab7eab3c2");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "f934da16-791a-427b-9929-763635627122");

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
        }
    }
}
