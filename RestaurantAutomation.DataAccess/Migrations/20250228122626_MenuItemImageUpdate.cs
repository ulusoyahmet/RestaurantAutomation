using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAutomation.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MenuItemImageUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "MenuItems",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "MenuItems");
        }
    }
}
