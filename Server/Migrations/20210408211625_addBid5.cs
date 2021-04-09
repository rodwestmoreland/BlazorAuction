using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorAuction.Server.Migrations
{
    public partial class addBid5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BidId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BidId",
                table: "Vehicles",
                column: "BidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Bids_BidId",
                table: "Vehicles",
                column: "BidId",
                principalTable: "Bids",
                principalColumn: "BidId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Bids_BidId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BidId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BidId",
                table: "Vehicles");
        }
    }
}
