using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveddaPizzaria.DataAccess.Migrations
{
    public partial class RemovePizzaSizeFromPizzaPreset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaSize",
                table: "PizzaPresets");

            migrationBuilder.AlterColumn<float>(
                name: "TotalPrice",
                table: "PizzaOrderDetails",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "PizzaPresets",
                columns: new[] { "PizzaId", "HasBeef", "HasCheese", "HasHam", "HasMushroom", "HasPepperoni", "HasPineapple", "HasPrawn", "HasTuna", "ImageTitle", "PizzaName", "PizzaSauce" },
                values: new object[,]
                {
                    { 1, false, true, false, false, false, false, false, false, "Margerita.png", "Margerita", 1 },
                    { 2, true, true, false, false, false, false, false, false, "Bolognese.png", "Bolognese", 1 },
                    { 3, false, true, true, false, false, true, true, false, "Hawaiian.png", "Hawaiian", 1 },
                    { 4, false, true, true, true, false, false, false, false, "Carbonara.png", "Carbonara", 1 },
                    { 5, true, true, true, false, false, false, false, false, "MeatFeast.png", "MeatFeast", 1 },
                    { 6, false, true, false, true, false, false, false, false, "Mushroom.png", "Mushroom", 1 },
                    { 7, false, true, false, false, true, false, false, false, "Pepperoni.png", "Pepperoni", 1 },
                    { 8, false, true, false, false, false, false, true, true, "Seafood.png", "Seafood", 1 },
                    { 9, false, true, false, true, false, true, false, false, "Vegetarian.png", "Vegetarian", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PizzaPresets",
                keyColumn: "PizzaId",
                keyValue: 9);

            migrationBuilder.AddColumn<int>(
                name: "PizzaSize",
                table: "PizzaPresets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalPrice",
                table: "PizzaOrderDetails",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
