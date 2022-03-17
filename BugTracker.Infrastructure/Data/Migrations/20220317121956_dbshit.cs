using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class dbshit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employees_ProjectEmployeesId",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projects_EmployeeProjectsId",
                table: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "ProjectEmployeesId",
                table: "EmployeeProject",
                newName: "ProjectsId");

            migrationBuilder.RenameColumn(
                name: "EmployeeProjectsId",
                table: "EmployeeProject",
                newName: "EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeProject_ProjectEmployeesId",
                table: "EmployeeProject",
                newName: "IX_EmployeeProject_ProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employees_EmployeesId",
                table: "EmployeeProject",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectsId",
                table: "EmployeeProject",
                column: "ProjectsId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employees_EmployeesId",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectsId",
                table: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "ProjectsId",
                table: "EmployeeProject",
                newName: "ProjectEmployeesId");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "EmployeeProject",
                newName: "EmployeeProjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeProject_ProjectsId",
                table: "EmployeeProject",
                newName: "IX_EmployeeProject_ProjectEmployeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employees_ProjectEmployeesId",
                table: "EmployeeProject",
                column: "ProjectEmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projects_EmployeeProjectsId",
                table: "EmployeeProject",
                column: "EmployeeProjectsId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
