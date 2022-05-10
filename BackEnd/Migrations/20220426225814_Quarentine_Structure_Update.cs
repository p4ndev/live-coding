using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class Quarentine_Structure_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeActivities_ActivityTypes_ActivityTypeId",
                table: "EmployeeActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeActivities_Employees_EmployeeId",
                table: "EmployeeActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_Quarentines_Employees_EmployeeId",
                table: "Quarentines");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Quarentines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelatedEmail",
                table: "Quarentines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeActivities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActivityTypeId",
                table: "EmployeeActivities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ActivityTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeActivities_ActivityTypes_ActivityTypeId",
                table: "EmployeeActivities",
                column: "ActivityTypeId",
                principalTable: "ActivityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeActivities_Employees_EmployeeId",
                table: "EmployeeActivities",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quarentines_Employees_EmployeeId",
                table: "Quarentines",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeActivities_ActivityTypes_ActivityTypeId",
                table: "EmployeeActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeActivities_Employees_EmployeeId",
                table: "EmployeeActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_Quarentines_Employees_EmployeeId",
                table: "Quarentines");

            migrationBuilder.DropColumn(
                name: "RelatedEmail",
                table: "Quarentines");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Quarentines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeActivities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityTypeId",
                table: "EmployeeActivities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ActivityTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeActivities_ActivityTypes_ActivityTypeId",
                table: "EmployeeActivities",
                column: "ActivityTypeId",
                principalTable: "ActivityTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeActivities_Employees_EmployeeId",
                table: "EmployeeActivities",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Quarentines_Employees_EmployeeId",
                table: "Quarentines",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
