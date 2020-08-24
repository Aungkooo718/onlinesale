using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineSalePrj.Migrations
{
    public partial class UpdatePurchaseItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseItems_Customers_CustomerId",
                table: "PurchaseItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseItems_CustomerId",
                table: "PurchaseItems");

            migrationBuilder.DropColumn(
                name: "BuyerName",
                table: "PurchaseItems");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PurchaseItems");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "PurchaseItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_OrderId",
                table: "PurchaseItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseItems_Orders_OrderId",
                table: "PurchaseItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseItems_Orders_OrderId",
                table: "PurchaseItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseItems_OrderId",
                table: "PurchaseItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "PurchaseItems");

            migrationBuilder.AddColumn<string>(
                name: "BuyerName",
                table: "PurchaseItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "PurchaseItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_CustomerId",
                table: "PurchaseItems",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseItems_Customers_CustomerId",
                table: "PurchaseItems",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
