using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class мъка : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_Organizations_OrganizationId",
                table: "Administrators");

            migrationBuilder.DropIndex(
                name: "IX_Administrators_OrganizationId",
                table: "Administrators");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "1c38f36a-75b3-4632-b8bc-95a5fe6a4e95");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "457bc242-3cd2-41f4-8acf-2cf5d5f9be77");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "af08b712-0ad5-4a7d-a14f-20ca2b0ad01d");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "ba2828d1-73b7-4d3e-9eee-d302c659da5d");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "0e6cfb0b-4c99-472c-82bd-dc429b386ca2");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "41dee263-4b0d-4632-8463-548650b9c15b");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "b7f1aa12-fea6-4a45-a9f6-21a9b855b53c");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "cc63d912-0eeb-4a29-a637-a3a6815fb881");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "fabf2d34-0d79-49b2-b991-0287132722c3");

            migrationBuilder.AlterColumn<string>(
                name: "AdministratiorId",
                table: "Organizations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OrganizationId",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AdministratiorId",
                table: "Organizations",
                column: "AdministratiorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Administrators_AdministratiorId",
                table: "Organizations",
                column: "AdministratiorId",
                principalTable: "Administrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Administrators_AdministratiorId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_AdministratiorId",
                table: "Organizations");

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

            migrationBuilder.AlterColumn<string>(
                name: "AdministratiorId",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "OrganizationId",
                table: "Administrators",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1c38f36a-75b3-4632-b8bc-95a5fe6a4e95", "emergency" },
                    { "457bc242-3cd2-41f4-8acf-2cf5d5f9be77", "urgent" },
                    { "af08b712-0ad5-4a7d-a14f-20ca2b0ad01d", "normal" },
                    { "ba2828d1-73b7-4d3e-9eee-d302c659da5d", "low" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0e6cfb0b-4c99-472c-82bd-dc429b386ca2", "on hold" },
                    { "41dee263-4b0d-4632-8463-548650b9c15b", "closed" },
                    { "b7f1aa12-fea6-4a45-a9f6-21a9b855b53c", "new" },
                    { "cc63d912-0eeb-4a29-a637-a3a6815fb881", "in progress" },
                    { "fabf2d34-0d79-49b2-b991-0287132722c3", "solved" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_OrganizationId",
                table: "Administrators",
                column: "OrganizationId",
                unique: true,
                filter: "[OrganizationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_Organizations_OrganizationId",
                table: "Administrators",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
