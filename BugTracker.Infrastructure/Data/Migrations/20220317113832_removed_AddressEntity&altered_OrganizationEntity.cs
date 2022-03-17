using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class removed_AddressEntityaltered_OrganizationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Addresses_AddressId",
                table: "Organizations");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_AddressId",
                table: "Organizations");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "18a261b4-7610-4bc1-b30c-df8821b9ca8a");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "1e433816-cc0b-423b-9a32-fa018ff3d98d");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "79ff6b44-8df8-45d6-8770-0ec327a73caa");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "cacafdc9-5402-4df0-b44e-6e9d3533ea76");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "066fec01-6277-4760-b221-7443f1aa7bba");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "59b5ff24-a219-4b8e-843b-abe55f7650cd");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "6e16cafc-b7b6-4502-838a-60686f0a4526");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "a8230807-c702-43be-995c-49faee7d2f2e");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "de5f8bf9-903f-48c8-9a6a-a8796b01a21d");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Organizations");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organizations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Organizations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetNumber",
                table: "Organizations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TownName",
                table: "Organizations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "TownName",
                table: "Organizations");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "AddressId",
                table: "Organizations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StreetNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "18a261b4-7610-4bc1-b30c-df8821b9ca8a", "low" },
                    { "1e433816-cc0b-423b-9a32-fa018ff3d98d", "normal" },
                    { "79ff6b44-8df8-45d6-8770-0ec327a73caa", "urgent" },
                    { "cacafdc9-5402-4df0-b44e-6e9d3533ea76", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "066fec01-6277-4760-b221-7443f1aa7bba", "solved" },
                    { "59b5ff24-a219-4b8e-843b-abe55f7650cd", "in progress" },
                    { "6e16cafc-b7b6-4502-838a-60686f0a4526", "on hold" },
                    { "a8230807-c702-43be-995c-49faee7d2f2e", "new" },
                    { "de5f8bf9-903f-48c8-9a6a-a8796b01a21d", "closed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AddressId",
                table: "Organizations",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Addresses_AddressId",
                table: "Organizations",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
