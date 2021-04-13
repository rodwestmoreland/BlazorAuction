using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorAuction.Server.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "BidEndAmount", "BidEndDate", "BidId", "BidStartDate", "BidderId", "Color", "Condition", "Cylinders", "Damage", "DriveTrain", "FuelType", "Make", "Mileage", "Model", "StartAmount", "TitleType", "VehicleImagePath", "WinnerId", "Year", "myCount" },
                values: new object[,]
                {
                    { 1, 0.0m, null, null, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 782, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, -4, 0, 0, 0)), null, "Black", null, 8, null, null, null, "Pontiac", 82000, "Firebird", 850m, "Clean", "img/1968Firebird.jpg", null, 1968, 0 },
                    { 2, 0.0m, null, null, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 782, DateTimeKind.Unspecified).AddTicks(8249), new TimeSpan(0, -4, 0, 0, 0)), null, "White", null, 8, null, null, null, "Ford", 150000, "F150", 1150m, "Clean", "img/1998F150.jpg", null, 1998, 0 },
                    { 3, 0.0m, null, null, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 782, DateTimeKind.Unspecified).AddTicks(8273), new TimeSpan(0, -4, 0, 0, 0)), null, "Blue", null, 6, null, null, null, "Ford", 23000, "Ranger", 250m, "Flood", "img/1998Ranger.jpg", null, 1998, 0 },
                    { 4, 0.0m, null, null, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 782, DateTimeKind.Unspecified).AddTicks(8280), new TimeSpan(0, -4, 0, 0, 0)), null, "Black", null, 6, null, null, null, "BMW", 102000, "i530", 4050m, "Rebuilt", "img/2006i530.jpg", null, 2006, 0 },
                    { 5, 0.0m, null, null, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 782, DateTimeKind.Unspecified).AddTicks(8286), new TimeSpan(0, -4, 0, 0, 0)), null, "Silver", null, 4, null, null, null, "Chevy", 10000, "Volt", 450m, "Salvage", "img/2010Volt.jpg", null, 2010, 0 },
                    { 6, 0.0m, null, null, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 782, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, -4, 0, 0, 0)), null, "Black", null, 4, null, null, null, "Volvo", 23000, "S60", 13850m, "Clean", "img/2019S60.jpg", null, 2019, 0 }
                });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "BidId", "BidTimeCreated", "BidderId", "HighBid", "VehicleId", "myCount" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 777, DateTimeKind.Unspecified).AddTicks(1123), new TimeSpan(0, -4, 0, 0, 0)), 0, 1200m, 1, 0 },
                    { 2, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 780, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, -4, 0, 0, 0)), 0, 1500m, 1, 0 },
                    { 6, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 780, DateTimeKind.Unspecified).AddTicks(4084), new TimeSpan(0, -4, 0, 0, 0)), 0, 1600m, 1, 0 },
                    { 3, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 780, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, -4, 0, 0, 0)), 0, 2300m, 2, 0 },
                    { 4, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 780, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, -4, 0, 0, 0)), 0, 500m, 3, 0 },
                    { 5, new DateTimeOffset(new DateTime(2021, 4, 12, 15, 52, 59, 780, DateTimeKind.Unspecified).AddTicks(4079), new TimeSpan(0, -4, 0, 0, 0)), 0, 5000m, 4, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4);
        }
    }
}
