using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveddaPizzaria.Migrations
{
    public partial class ModifiedPizzaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "PizzaPresets");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "PizzaPresets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "BasePrice",
                table: "PizzaPresets",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "PizzaPresets",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
