using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMatic.Migrations
{
    public partial class addReservationConstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_ParkingSpot_ParkingSpotID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Vehicle_VehicleID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Pass_PassID",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "PassID",
                table: "Vehicle",
                newName: "PassId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Vehicle",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_PassID",
                table: "Vehicle",
                newName: "IX_Vehicle_PassId");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "Reservation",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "ParkingSpotID",
                table: "Reservation",
                newName: "ParkingSpotId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Reservation",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_VehicleID",
                table: "Reservation",
                newName: "IX_Reservation_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ParkingSpotID",
                table: "Reservation",
                newName: "IX_Reservation_ParkingSpotId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ParkingSpot",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_ParkingSpot_ParkingSpotId",
                table: "Reservation",
                column: "ParkingSpotId",
                principalTable: "ParkingSpot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Vehicle_VehicleId",
                table: "Reservation",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Pass_PassId",
                table: "Vehicle",
                column: "PassId",
                principalTable: "Pass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_ParkingSpot_ParkingSpotId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Vehicle_VehicleId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Pass_PassId",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "PassId",
                table: "Vehicle",
                newName: "PassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicle",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_PassId",
                table: "Vehicle",
                newName: "IX_Vehicle_PassID");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Reservation",
                newName: "VehicleID");

            migrationBuilder.RenameColumn(
                name: "ParkingSpotId",
                table: "Reservation",
                newName: "ParkingSpotID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reservation",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_VehicleId",
                table: "Reservation",
                newName: "IX_Reservation_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ParkingSpotId",
                table: "Reservation",
                newName: "IX_Reservation_ParkingSpotID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pass",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ParkingSpot",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_ParkingSpot_ParkingSpotID",
                table: "Reservation",
                column: "ParkingSpotID",
                principalTable: "ParkingSpot",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Vehicle_VehicleID",
                table: "Reservation",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Pass_PassID",
                table: "Vehicle",
                column: "PassID",
                principalTable: "Pass",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
