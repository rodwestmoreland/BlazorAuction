using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorAuction.Server.Migrations
{
    public partial class addBidTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "BidTimeCreated",
                table: "Bids",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BidTimeCreated",
                table: "Bids");
        }
    }
}
