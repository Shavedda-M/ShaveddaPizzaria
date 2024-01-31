using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveddaPizzaria.DataAccess.Migrations
{
    public partial class RemoveImageTitleFromOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "PizzaOrderDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "PizzaOrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
