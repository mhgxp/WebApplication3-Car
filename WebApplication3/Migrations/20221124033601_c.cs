using Microsoft.EntityFrameworkCore.Migrations;

namespace Car.Migrations
{
    public partial class c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Employee_EmployeeId",
                table: "Bill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarInfo",
                table: "CarInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CarInfo");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "Bill");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employee",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Customer",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "CarItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CarInfo",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "CarInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarItemId",
                table: "CarInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Brand",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Bill",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarInfo",
                table: "CarInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CarInfo_BrandId",
                table: "CarInfo",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CarInfo_CarItemId",
                table: "CarInfo",
                column: "CarItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CustomerId",
                table: "Bill",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Customer_CustomerId",
                table: "Bill",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Employee_EmployeeId",
                table: "Bill",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarInfo_Brand_BrandId",
                table: "CarInfo",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarInfo_CarItem_CarItemId",
                table: "CarInfo",
                column: "CarItemId",
                principalTable: "CarItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Customer_CustomerId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Employee_EmployeeId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_CarInfo_Brand_BrandId",
                table: "CarInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_CarInfo_CarItem_CarItemId",
                table: "CarInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarInfo",
                table: "CarInfo");

            migrationBuilder.DropIndex(
                name: "IX_CarInfo_BrandId",
                table: "CarInfo");

            migrationBuilder.DropIndex(
                name: "IX_CarInfo_CarItemId",
                table: "CarInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_CustomerId",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CarItem");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CarInfo");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "CarInfo");

            migrationBuilder.DropColumn(
                name: "CarItemId",
                table: "CarInfo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Bill");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "CarInfo",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Brand",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BillId",
                table: "Bill",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarInfo",
                table: "CarInfo",
                column: "CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Employee_EmployeeId",
                table: "Bill",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
