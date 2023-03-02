using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_MyFlight_flightsflightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_passengerspassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_planeId",
                table: "MyFlight");

            migrationBuilder.DropIndex(
                name: "IX_MyFlight_planeId",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "planeId",
                table: "MyFlight");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "My Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_passengerspassportNumber",
                table: "My Reservation",
                newName: "IX_My Reservation_passengerspassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFk",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_My Reservation",
                table: "My Reservation",
                columns: new[] { "flightsflightId", "passengerspassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_PlaneFk",
                table: "MyFlight",
                column: "PlaneFk");

            migrationBuilder.AddForeignKey(
                name: "FK_My Reservation_MyFlight_flightsflightId",
                table: "My Reservation",
                column: "flightsflightId",
                principalTable: "MyFlight",
                principalColumn: "flightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_My Reservation_Passengers_passengerspassportNumber",
                table: "My Reservation",
                column: "passengerspassportNumber",
                principalTable: "Passengers",
                principalColumn: "passportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_PlaneFk",
                table: "MyFlight",
                column: "PlaneFk",
                principalTable: "Planes",
                principalColumn: "planeId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_My Reservation_MyFlight_flightsflightId",
                table: "My Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_My Reservation_Passengers_passengerspassportNumber",
                table: "My Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_PlaneFk",
                table: "MyFlight");

            migrationBuilder.DropIndex(
                name: "IX_MyFlight_PlaneFk",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_My Reservation",
                table: "My Reservation");

            migrationBuilder.RenameTable(
                name: "My Reservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_My Reservation_passengerspassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_passengerspassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFk",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planeId",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "flightsflightId", "passengerspassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_planeId",
                table: "MyFlight",
                column: "planeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_MyFlight_flightsflightId",
                table: "FlightPassenger",
                column: "flightsflightId",
                principalTable: "MyFlight",
                principalColumn: "flightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_passengerspassportNumber",
                table: "FlightPassenger",
                column: "passengerspassportNumber",
                principalTable: "Passengers",
                principalColumn: "passportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_planeId",
                table: "MyFlight",
                column: "planeId",
                principalTable: "Planes",
                principalColumn: "planeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
