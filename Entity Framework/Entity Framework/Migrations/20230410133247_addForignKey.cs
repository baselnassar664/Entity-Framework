using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework.Migrations
{
    public partial class addForignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentIdDept",
                table: "Employess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 10, 16, 32, 47, 538, DateTimeKind.Local).AddTicks(8090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 7, 18, 10, 0, 948, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.CreateIndex(
                name: "IX_Employess_DepartmentIdDept",
                table: "Employess",
                column: "DepartmentIdDept");

            migrationBuilder.AddForeignKey(
                name: "FK_Employess_Departments_DepartmentIdDept",
                table: "Employess",
                column: "DepartmentIdDept",
                principalTable: "Departments",
                principalColumn: "IdDept",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employess_Departments_DepartmentIdDept",
                table: "Employess");

            migrationBuilder.DropIndex(
                name: "IX_Employess_DepartmentIdDept",
                table: "Employess");

            migrationBuilder.DropColumn(
                name: "DepartmentIdDept",
                table: "Employess");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 7, 18, 10, 0, 948, DateTimeKind.Local).AddTicks(1549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 10, 16, 32, 47, 538, DateTimeKind.Local).AddTicks(8090));
        }
    }
}
