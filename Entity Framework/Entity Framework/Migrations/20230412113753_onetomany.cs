using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employess_DeptId",
                table: "Employess");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentIdDept",
                table: "Employess",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 12, 14, 37, 53, 353, DateTimeKind.Local).AddTicks(6718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 12, 14, 19, 10, 77, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.CreateIndex(
                name: "IX_Employess_DepartmentIdDept",
                table: "Employess",
                column: "DepartmentIdDept");

            migrationBuilder.CreateIndex(
                name: "IX_Employess_DeptId",
                table: "Employess",
                column: "DeptId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employess_Departments_DepartmentIdDept",
                table: "Employess",
                column: "DepartmentIdDept",
                principalTable: "Departments",
                principalColumn: "IdDept");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employess_Departments_DepartmentIdDept",
                table: "Employess");

            migrationBuilder.DropIndex(
                name: "IX_Employess_DepartmentIdDept",
                table: "Employess");

            migrationBuilder.DropIndex(
                name: "IX_Employess_DeptId",
                table: "Employess");

            migrationBuilder.DropColumn(
                name: "DepartmentIdDept",
                table: "Employess");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 12, 14, 19, 10, 77, DateTimeKind.Local).AddTicks(1183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 12, 14, 37, 53, 353, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.CreateIndex(
                name: "IX_Employess_DeptId",
                table: "Employess",
                column: "DeptId");
        }
    }
}
