using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_entitycomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "0e7d7f23-ed11-4a32-b7e6-2be9855779b2");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "622b3c35-5cf1-46dc-adc8-dcffb9866224");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "7fda0663-105d-47ce-a21f-30171a6e7f6d");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "b1451edd-6867-4ee4-a48a-9a3cf1473315");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "6b14d180-1a34-4945-bf9d-b91306cafbc4");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "8a69f11c-b9d6-4c86-a0b2-a5ab36142b4b");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "a4c841ae-3ce7-482c-9cc8-c147da7c3fda");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "adeb8759-53dd-4f81-bbaa-d4554d1f1a81");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c0795493-819b-4059-bd84-de10eae933df");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BugId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Bugs_BugId",
                        column: x => x.BugId,
                        principalTable: "Bugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "20fefa88-ecc7-4263-867c-8d7629015bb0", "emergency" },
                    { "68c62de4-5920-4a5a-b506-a54c468094c4", "normal" },
                    { "756bb541-1f74-4f3d-b808-0e11d150d7ee", "urgent" },
                    { "e7f9c712-b972-4818-9d11-72a9e5e9cee4", "low" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "26314a38-2d6d-45fa-98da-0931b40de885", "on hold" },
                    { "3bdeca53-8666-4c97-872e-287fda168b7a", "in progress" },
                    { "5a4bc77c-45cf-4ca6-9d13-bb002fa69ab8", "new" },
                    { "777764d8-3471-4a30-9f63-b2a374acd91f", "solved" },
                    { "78e8584c-554e-4384-9042-4ca47cf7f948", "closed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BugId",
                table: "Comments",
                column: "BugId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "20fefa88-ecc7-4263-867c-8d7629015bb0");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "68c62de4-5920-4a5a-b506-a54c468094c4");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "756bb541-1f74-4f3d-b808-0e11d150d7ee");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "e7f9c712-b972-4818-9d11-72a9e5e9cee4");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "26314a38-2d6d-45fa-98da-0931b40de885");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "3bdeca53-8666-4c97-872e-287fda168b7a");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "5a4bc77c-45cf-4ca6-9d13-bb002fa69ab8");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "777764d8-3471-4a30-9f63-b2a374acd91f");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "78e8584c-554e-4384-9042-4ca47cf7f948");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0e7d7f23-ed11-4a32-b7e6-2be9855779b2", "urgent" },
                    { "622b3c35-5cf1-46dc-adc8-dcffb9866224", "normal" },
                    { "7fda0663-105d-47ce-a21f-30171a6e7f6d", "low" },
                    { "b1451edd-6867-4ee4-a48a-9a3cf1473315", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "6b14d180-1a34-4945-bf9d-b91306cafbc4", "solved" },
                    { "8a69f11c-b9d6-4c86-a0b2-a5ab36142b4b", "in progress" },
                    { "a4c841ae-3ce7-482c-9cc8-c147da7c3fda", "closed" },
                    { "adeb8759-53dd-4f81-bbaa-d4554d1f1a81", "on hold" },
                    { "c0795493-819b-4059-bd84-de10eae933df", "new" }
                });
        }
    }
}
