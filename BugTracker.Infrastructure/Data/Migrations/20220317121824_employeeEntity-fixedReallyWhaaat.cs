using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class employeeEntityfixedReallyWhaaat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectEmployeesId1",
                table: "EmployeeProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeProject",
                table: "EmployeeProject");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeProject_ProjectEmployeesId1",
                table: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "ProjectEmployeesId1",
                table: "EmployeeProject",
                newName: "EmployeeProjectsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeProject",
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectsId", "ProjectEmployeesId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectEmployeesId",
                table: "EmployeeProject",
                column: "ProjectEmployeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projects_EmployeeProjectsId",
                table: "EmployeeProject",
                column: "EmployeeProjectsId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projects_EmployeeProjectsId",
                table: "EmployeeProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeProject",
                table: "EmployeeProject");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeProject_ProjectEmployeesId",
                table: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "EmployeeProjectsId",
                table: "EmployeeProject",
                newName: "ProjectEmployeesId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeProject",
                table: "EmployeeProject",
                columns: new[] { "ProjectEmployeesId", "ProjectEmployeesId1" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectEmployeesId1",
                table: "EmployeeProject",
                column: "ProjectEmployeesId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectEmployeesId1",
                table: "EmployeeProject",
                column: "ProjectEmployeesId1",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
