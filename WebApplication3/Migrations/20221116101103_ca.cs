using Microsoft.EntityFrameworkCore.Migrations;

namespace Car.Migrations
{
    public partial class ca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bill_EmployeeId",
                table: "Bill",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Employee_EmployeeId",
                table: "Bill",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Employee_EmployeeId",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_EmployeeId",
                table: "Bill");
        }
    }
}
