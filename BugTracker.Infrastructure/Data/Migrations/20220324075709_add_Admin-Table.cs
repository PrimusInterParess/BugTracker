using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_AdminTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrators_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Administrators_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_OrganizationId",
                table: "Administrators",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_UserId",
                table: "Administrators",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

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
    }
}
