using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class add_entitycommentemployeecomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Bugs_BugId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BugId",
                table: "Comments");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BugId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1f542da6-2d66-475e-8786-0335140ac457", "urgent" },
                    { "52fc1280-4e16-4562-88b1-0c83c0f7ac8e", "normal" },
                    { "611b9fe0-3385-4669-b9a0-0e759ae1c9c8", "low" },
                    { "9710597b-d6be-45b2-9996-732ea39f4c83", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "54750b38-de9d-41d2-b6c0-d430e491571a", "new" },
                    { "638ed63b-c782-4f10-95e7-903f459320f9", "closed" },
                    { "c674a7d4-2da0-491f-acd7-5fc62a83de8c", "on hold" },
                    { "d06372f3-f41f-456e-a7d3-0c911323026e", "in progress" },
                    { "d6208e32-a70b-46d0-91e8-3b877784118a", "solved" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Bugs_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Bugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Employees_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Bugs_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Employees_UserId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "1f542da6-2d66-475e-8786-0335140ac457");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "52fc1280-4e16-4562-88b1-0c83c0f7ac8e");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "611b9fe0-3385-4669-b9a0-0e759ae1c9c8");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "9710597b-d6be-45b2-9996-732ea39f4c83");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "54750b38-de9d-41d2-b6c0-d430e491571a");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "638ed63b-c782-4f10-95e7-903f459320f9");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c674a7d4-2da0-491f-acd7-5fc62a83de8c");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "d06372f3-f41f-456e-a7d3-0c911323026e");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "d6208e32-a70b-46d0-91e8-3b877784118a");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BugId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Bugs_BugId",
                table: "Comments",
                column: "BugId",
                principalTable: "Bugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
