using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class addlogoUrlorganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "20265d75-d6df-45ad-92a1-e439fc7d0261");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "2935b1a2-f26d-4d97-9a62-70bc09c2a848");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "4468f295-e4e0-4f92-b162-be958c217925");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "f9fdcf48-40d0-41a2-a3fc-b947fe648a51");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "3358ff63-ddee-4085-a1c7-e8c00e5e7fa7");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "575ae99e-7893-466a-b037-c4b355ef5fcc");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "b8958182-76b6-4997-924e-b308c5048a67");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c09bb997-0364-44c0-93f9-c97a8d0b9717");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c0d4cde8-e1dd-482b-9a56-adada0c453c8");

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Organizations");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "20265d75-d6df-45ad-92a1-e439fc7d0261", "urgent" },
                    { "2935b1a2-f26d-4d97-9a62-70bc09c2a848", "low" },
                    { "4468f295-e4e0-4f92-b162-be958c217925", "emergency" },
                    { "f9fdcf48-40d0-41a2-a3fc-b947fe648a51", "normal" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "3358ff63-ddee-4085-a1c7-e8c00e5e7fa7", "in progress" },
                    { "575ae99e-7893-466a-b037-c4b355ef5fcc", "new" },
                    { "b8958182-76b6-4997-924e-b308c5048a67", "on hold" },
                    { "c09bb997-0364-44c0-93f9-c97a8d0b9717", "solved" },
                    { "c0d4cde8-e1dd-482b-9a56-adada0c453c8", "closed" }
                });
        }
    }
}
