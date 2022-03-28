using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class altercolumn_organizationStreetNamerequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "39edeecc-4acd-49fa-a4cf-2053d3bb91c4");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "4bc0f610-7d49-4db3-85b7-42f076493767");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "a0de7398-728d-468f-8fed-9d7b23e217d1");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "a6ed0c66-4f82-4c50-a7ce-df0e71938ac2");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "485033da-da62-44d1-8330-2daf31a1a26c");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "6be2b56d-41df-4e18-a406-f31c929d001e");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "96268c0a-a4f8-40ac-8427-68b2ffa48502");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c09d42da-fb29-4e41-8f41-9cf53274657e");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "e3a67592-8e24-402f-9fec-bf48b0458b67");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "39edeecc-4acd-49fa-a4cf-2053d3bb91c4", "low" },
                    { "4bc0f610-7d49-4db3-85b7-42f076493767", "normal" },
                    { "a0de7398-728d-468f-8fed-9d7b23e217d1", "emergency" },
                    { "a6ed0c66-4f82-4c50-a7ce-df0e71938ac2", "urgent" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "485033da-da62-44d1-8330-2daf31a1a26c", "on hold" },
                    { "6be2b56d-41df-4e18-a406-f31c929d001e", "closed" },
                    { "96268c0a-a4f8-40ac-8427-68b2ffa48502", "in progress" },
                    { "c09d42da-fb29-4e41-8f41-9cf53274657e", "solved" },
                    { "e3a67592-8e24-402f-9fec-bf48b0458b67", "new" }
                });
        }
    }
}
