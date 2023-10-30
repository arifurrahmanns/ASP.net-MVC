using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodOrdering.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBSetup4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Orders",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "Orders",
                newName: "food_id");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Foods",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Foods",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Foods",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "food_id",
                table: "Orders",
                newName: "FoodId");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Foods",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Foods",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Foods",
                newName: "Id");
        }
    }
}
