using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Database.Migrations
{
    public partial class StockOnHoldSessionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StocksOnHolds_Stock_StockId",
                table: "StocksOnHolds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StocksOnHolds",
                table: "StocksOnHolds");

            migrationBuilder.RenameTable(
                name: "StocksOnHolds",
                newName: "StocksOnHold");

            migrationBuilder.RenameIndex(
                name: "IX_StocksOnHolds_StockId",
                table: "StocksOnHold",
                newName: "IX_StocksOnHold_StockId");

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "StocksOnHold",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StocksOnHold",
                table: "StocksOnHold",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StocksOnHold_Stock_StockId",
                table: "StocksOnHold",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StocksOnHold_Stock_StockId",
                table: "StocksOnHold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StocksOnHold",
                table: "StocksOnHold");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "StocksOnHold");

            migrationBuilder.RenameTable(
                name: "StocksOnHold",
                newName: "StocksOnHolds");

            migrationBuilder.RenameIndex(
                name: "IX_StocksOnHold_StockId",
                table: "StocksOnHolds",
                newName: "IX_StocksOnHolds_StockId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StocksOnHolds",
                table: "StocksOnHolds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StocksOnHolds_Stock_StockId",
                table: "StocksOnHolds",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
