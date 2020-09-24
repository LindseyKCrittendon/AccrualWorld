using Microsoft.EntityFrameworkCore.Migrations;

namespace AccrualWorld.Data.Migrations
{
    public partial class changedMisspelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpeseTypes_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpeseTypes",
                table: "ExpeseTypes");

            migrationBuilder.RenameTable(
                name: "ExpeseTypes",
                newName: "ExpenseTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpenseTypes",
                table: "ExpenseTypes",
                column: "ExpenseTypeId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d5de50c-036c-4bee-a50a-727e9d8025b9", "AQAAAAEAACcQAAAAEL2uw4oitR9V0nf06pzny9owojIbyKCDHsA816Wa2Tz1ndeOjFy//awhXB23bkhwHQ==", "3caa8df7-f390-4b97-8f71-58d9e34e675f" });

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "ExpenseTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpenseTypes",
                table: "ExpenseTypes");

            migrationBuilder.RenameTable(
                name: "ExpenseTypes",
                newName: "ExpeseTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpeseTypes",
                table: "ExpeseTypes",
                column: "ExpenseTypeId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90f6087d-a573-4965-a1c2-dd6cc81988a3", "AQAAAAEAACcQAAAAEHxYSD/kSGYnPqwAJfPBFYHS9WMbqeNGKQldBVdGUV++cwR9qPh0AgbNY5RpCjsg2w==", "69ddaff4-5036-4dc1-8d5a-0821fd274583" });

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpeseTypes_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId",
                principalTable: "ExpeseTypes",
                principalColumn: "ExpenseTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
