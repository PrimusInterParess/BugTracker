using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class alter_tablesRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Status_StatusId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DepartmentId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "6739d464-71c7-45c9-8a7c-496bb8d3002b");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "a028f9dc-7925-46a1-9eea-438710e3318c");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "fb226cca-bbef-416e-9111-2bd48d9ab1e3");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: "ffda0fae-b608-44e7-bad4-7caea50fdbc6");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "84725746-e12e-47b3-8c5c-5f839fd32d37");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "8631f429-ebdc-4a46-b3b6-1a6c7b3dcb30");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "c243017d-d85c-412b-9549-eb7f7b35c822");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "cfcbeec1-a1b6-4a70-b3f7-24d3eba055ea");

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: "f3e6b6f5-98d8-41d5-932f-dcc53d31739a");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Status_StatusId",
                table: "Bugs",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DepartmentId",
                table: "Projects",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Status_StatusId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DepartmentId",
                table: "Projects");

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

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "6739d464-71c7-45c9-8a7c-496bb8d3002b", "urgent" },
                    { "a028f9dc-7925-46a1-9eea-438710e3318c", "normal" },
                    { "fb226cca-bbef-416e-9111-2bd48d9ab1e3", "low" },
                    { "ffda0fae-b608-44e7-bad4-7caea50fdbc6", "emergency" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "84725746-e12e-47b3-8c5c-5f839fd32d37", "solved" },
                    { "8631f429-ebdc-4a46-b3b6-1a6c7b3dcb30", "closed" },
                    { "c243017d-d85c-412b-9549-eb7f7b35c822", "new" },
                    { "cfcbeec1-a1b6-4a70-b3f7-24d3eba055ea", "on hold" },
                    { "f3e6b6f5-98d8-41d5-932f-dcc53d31739a", "in progress" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Priorities_PriorityId",
                table: "Bugs",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Status_StatusId",
                table: "Bugs",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DepartmentId",
                table: "Projects",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
