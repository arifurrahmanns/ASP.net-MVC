using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodOrdering.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBSetup3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
