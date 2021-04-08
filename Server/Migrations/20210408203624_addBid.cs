using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorAuction.Server.Migrations
{
    public partial class addBid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Vehicles_VehicleId",
                table: "Bids");

            migrationBuilder.DropIndex(
                name: "IX_Bids_VehicleId",
                table: "Bids");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Bids");

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

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Bids",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bids_VehicleId",
                table: "Bids",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Vehicles_VehicleId",
                table: "Bids",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
