using Microsoft.EntityFrameworkCore.Migrations;

namespace PRScapstoneProj.Migrations
{
    public partial class AddedMethodsinRequestRL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Vendor",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vendor",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Vendor",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Vendor",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Vendor",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "User",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "User",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Request",
                type: "decimal(11, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IDX_Code",
                table: "Vendor",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestLine_ProductId",
                table: "RequestLine",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_RequestId",
                table: "Request",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                table: "Request",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IDX_PartNbr",
                table: "Product",
                column: "PartNbr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorId",
                table: "Product",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Vendor_VendorId",
                table: "Product",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_RequestLine_RequestId",
                table: "Request",
                column: "RequestId",
                principalTable: "RequestLine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_User_UserId",
                table: "Request",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLine_Product_ProductId",
                table: "RequestLine",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Vendor_VendorId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_RequestLine_RequestId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_User_UserId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestLine_Product_ProductId",
                table: "RequestLine");

            migrationBuilder.DropIndex(
                name: "IDX_Code",
                table: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_RequestLine_ProductId",
                table: "RequestLine");

            migrationBuilder.DropIndex(
                name: "IX_Request_RequestId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_UserId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IDX_PartNbr",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_VendorId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Request");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Vendor",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Vendor",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Vendor",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "User",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "User",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "Request",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11, 2)");
        }
    }
}
