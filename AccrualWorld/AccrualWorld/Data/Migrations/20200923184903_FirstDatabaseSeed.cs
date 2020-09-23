using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccrualWorld.Data.Migrations
{
    public partial class FirstDatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ExpeseTypes",
                columns: table => new
                {
                    ExpenseTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpeseTypes", x => x.ExpenseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    IncomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Total = table.Column<double>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Payer = table.Column<string>(maxLength: 55, nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.IncomeId);
                    table.ForeignKey(
                        name: "FK_Incomes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mileages",
                columns: table => new
                {
                    MileageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    AmountPerMile = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mileages", x => x.MileageId);
                    table.ForeignKey(
                        name: "FK_Mileages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseTypeId = table.Column<int>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpeseTypes_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "ExpeseTypes",
                        principalColumn: "ExpenseTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "1", 0, "90f6087d-a573-4965-a1c2-dd6cc81988a3", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHxYSD/kSGYnPqwAJfPBFYHS9WMbqeNGKQldBVdGUV++cwR9qPh0AgbNY5RpCjsg2w==", null, false, "69ddaff4-5036-4dc1-8d5a-0821fd274583", false, "admin@admin.com", "George", "Brown" });

            migrationBuilder.InsertData(
                table: "ExpeseTypes",
                columns: new[] { "ExpenseTypeId", "Label" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Entertainment" },
                    { 3, "Office Supplies" },
                    { 4, "Cell Phone" },
                    { 5, "Internet" },
                    { 6, "Electric" },
                    { 7, "Child Care" },
                    { 8, "Gifts" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "DateTime", "ExpenseTypeId", "ImagePath", "Total", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 10.5, "1" },
                    { 2, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 20.43, "1" },
                    { 3, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 14.369999999999999, "1" },
                    { 4, new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 12.99, "1" },
                    { 5, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 87.920000000000002, "1" },
                    { 6, new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 157.22, "1" },
                    { 7, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, 237.22999999999999, "1" },
                    { 8, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, 100.0, "1" }
                });

            migrationBuilder.InsertData(
                table: "Incomes",
                columns: new[] { "IncomeId", "DateTime", "Description", "ImagePath", "Payer", "Total", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legal Services 9/01/2020-09/15/2020", null, "Minutemen Press", 1000.0, "1" },
                    { 2, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrative Services in August", null, "Tommy Vance", 263.5, "1" }
                });

            migrationBuilder.InsertData(
                table: "Mileages",
                columns: new[] { "MileageId", "AmountPerMile", "DateTime", "Description", "Paid", "Total", "UserId" },
                values: new object[,]
                {
                    { 1, 0.41999999999999998, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Traveled to Ripley for Court", true, 143, "1" },
                    { 2, 0.0, new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Traveled to Parkersburg and back for consulting", false, 256, "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UserId",
                table: "Incomes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Mileages_UserId",
                table: "Mileages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "Mileages");

            migrationBuilder.DropTable(
                name: "ExpeseTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
