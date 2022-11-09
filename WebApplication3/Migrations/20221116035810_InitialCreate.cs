using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarItems",
                table: "CarItems");

            migrationBuilder.RenameTable(
                name: "CarItems",
                newName: "CarItem");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CarItem",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarItem",
                table: "CarItem",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<string>(nullable: true),
                    BuyDate = table.Column<DateTime>(nullable: false),
                    Secret = table.Column<string>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    Car = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    Customer = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    Employee = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.BillId);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    BrandAddress = table.Column<string>(nullable: true),
                    BrandAbout = table.Column<string>(nullable: false),
                    Secret = table.Column<string>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    Car = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "CarInfo",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(nullable: true),
                    VIN = table.Column<string>(nullable: true),
                    CarAbout = table.Column<string>(nullable: false),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    ImportDate = table.Column<string>(nullable: true),
                    Secret = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInfo", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerBirthday = table.Column<DateTime>(nullable: false),
                    CustomerAddress = table.Column<string>(nullable: true),
                    CustomerPhoneNumber = table.Column<long>(nullable: false),
                    Secret = table.Column<string>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    Car = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: true),
                    EmployeeBirthday = table.Column<DateTime>(nullable: false),
                    EmployeeAddress = table.Column<string>(nullable: true),
                    EmployeePhoneNumber = table.Column<string>(nullable: true),
                    Secret = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "CarInfo");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarItem",
                table: "CarItem");

            migrationBuilder.RenameTable(
                name: "CarItem",
                newName: "CarItems");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "CarItems",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarItems",
                table: "CarItems",
                column: "Id");
        }
    }
}
