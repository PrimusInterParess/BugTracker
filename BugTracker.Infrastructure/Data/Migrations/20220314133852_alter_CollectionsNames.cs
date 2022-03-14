using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Infrastructure.Data.Migrations
{
    public partial class alter_CollectionsNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugEmployee_Bugs_BugsId",
                table: "BugEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_BugEmployee_Employees_EmployeesId",
                table: "BugEmployee");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "BugEmployee",
                newName: "EmployeeBugsId");

            migrationBuilder.RenameColumn(
                name: "BugsId",
                table: "BugEmployee",
                newName: "BugEmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_BugEmployee_EmployeesId",
                table: "BugEmployee",
                newName: "IX_BugEmployee_EmployeeBugsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BugEmployee_Bugs_EmployeeBugsId",
                table: "BugEmployee",
                column: "EmployeeBugsId",
                principalTable: "Bugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BugEmployee_Employees_BugEmployeesId",
                table: "BugEmployee",
                column: "BugEmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugEmployee_Bugs_EmployeeBugsId",
                table: "BugEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_BugEmployee_Employees_BugEmployeesId",
                table: "BugEmployee");

            migrationBuilder.RenameColumn(
                name: "EmployeeBugsId",
                table: "BugEmployee",
                newName: "EmployeesId");

            migrationBuilder.RenameColumn(
                name: "BugEmployeesId",
                table: "BugEmployee",
                newName: "BugsId");

            migrationBuilder.RenameIndex(
                name: "IX_BugEmployee_EmployeeBugsId",
                table: "BugEmployee",
                newName: "IX_BugEmployee_EmployeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BugEmployee_Bugs_BugsId",
                table: "BugEmployee",
                column: "BugsId",
                principalTable: "Bugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BugEmployee_Employees_EmployeesId",
                table: "BugEmployee",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
