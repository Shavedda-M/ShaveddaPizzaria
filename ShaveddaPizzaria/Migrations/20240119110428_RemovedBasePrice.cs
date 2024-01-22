using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveddaPizzaria.Migrations
{
    public partial class RemovedBasePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "PizzaOrderDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "BasePrice",
                table: "PizzaOrderDetails",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
