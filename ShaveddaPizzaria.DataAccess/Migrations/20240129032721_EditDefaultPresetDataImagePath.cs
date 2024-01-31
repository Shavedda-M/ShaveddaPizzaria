using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveddaPizzaria.DataAccess.Migrations
{
    public partial class EditDefaultPresetDataImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 1,
                column: "ImagePath",
                value: "\\images\\presets\\Margerita.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 2,
                column: "ImagePath",
                value: "\\images\\presets\\Bolognese.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 3,
                column: "ImagePath",
                value: "\\images\\presets\\Hawaiian.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 4,
                column: "ImagePath",
                value: "\\images\\presets\\Carbonara.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 5,
                column: "ImagePath",
                value: "\\images\\presets\\MeatFeast.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 6,
                column: "ImagePath",
                value: "\\images\\presets\\Mushroom.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 7,
                column: "ImagePath",
                value: "\\images\\presets\\Pepperoni.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 8,
                column: "ImagePath",
                value: "\\images\\presets\\Seafood.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 9,
                column: "ImagePath",
                value: "\\images\\presets\\Vegetarian.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 1,
                column: "ImagePath",
                value: "images\\presets\\Margerita.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 2,
                column: "ImagePath",
                value: "images\\presets\\Bolognese.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 3,
                column: "ImagePath",
                value: "images\\presets\\Hawaiian.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 4,
                column: "ImagePath",
                value: "images\\presets\\Carbonara.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 5,
                column: "ImagePath",
                value: "images\\presets\\MeatFeast.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 6,
                column: "ImagePath",
                value: "images\\presets\\Mushroom.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 7,
                column: "ImagePath",
                value: "images\\presets\\Pepperoni.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 8,
                column: "ImagePath",
                value: "images\\presets\\Seafood.png");

            migrationBuilder.UpdateData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 9,
                column: "ImagePath",
                value: "images\\presets\\Vegetarian.png");
        }
    }
}
