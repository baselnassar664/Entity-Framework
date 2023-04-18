using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework.Migrations
{
    public partial class ForeignKeyDeptId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employess_Departments_DepartmentIdDept",
                table: "Employess");

            migrationBuilder.RenameColumn(
                name: "DepartmentIdDept",
                table: "Employess",
                newName: "DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employess_DepartmentIdDept",
                table: "Employess",
                newName: "IX_Employess_DeptId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 10, 17, 2, 30, 862, DateTimeKind.Local).AddTicks(7920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 10, 16, 32, 47, 538, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.AddForeignKey(
                name: "FK_Employess_Departments_DeptId",
                table: "Employess",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "IdDept",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employess_Departments_DeptId",
                table: "Employess");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Employess",
                newName: "DepartmentIdDept");

            migrationBuilder.RenameIndex(
                name: "IX_Employess_DeptId",
                table: "Employess",
                newName: "IX_Employess_DepartmentIdDept");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 10, 16, 32, 47, 538, DateTimeKind.Local).AddTicks(8090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 10, 17, 2, 30, 862, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.AddForeignKey(
                name: "FK_Employess_Departments_DepartmentIdDept",
                table: "Employess",
                column: "DepartmentIdDept",
                principalTable: "Departments",
                principalColumn: "IdDept",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
