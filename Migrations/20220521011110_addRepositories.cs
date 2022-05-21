using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMatic.Migrations
{
    public partial class addRepositories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Occupancy",
                table: "ParkingSpot",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Occupancy",
                table: "ParkingSpot");
        }
    }
}
