using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyACar.Migrations
{
    /// <inheritdoc />
    public partial class Models10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cars",
                newName: "WheelDrive");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FinnId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KilometersDriven",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductionYear",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SellerType",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StorageCapacity",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrailerWeight",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FinnId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "KilometersDriven",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ProductionYear",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SellerType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "StorageCapacity",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "TrailerWeight",
                table: "CarModels");

            migrationBuilder.RenameColumn(
                name: "WheelDrive",
                table: "Cars",
                newName: "Name");
        }
    }
}
