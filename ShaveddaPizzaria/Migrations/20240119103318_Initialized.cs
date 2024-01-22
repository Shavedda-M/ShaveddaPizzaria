using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShaveddaPizzaria.Migrations
{
    public partial class Initialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PizzaPresets",
                columns: table => new
                {
                    PizzaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaSize = table.Column<int>(type: "int", nullable: false),
                    PizzaSauce = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<float>(type: "real", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    HasCheese = table.Column<bool>(type: "bit", nullable: false),
                    HasPepperoni = table.Column<bool>(type: "bit", nullable: false),
                    HasMushroom = table.Column<bool>(type: "bit", nullable: false),
                    HasPineapple = table.Column<bool>(type: "bit", nullable: false),
                    HasTuna = table.Column<bool>(type: "bit", nullable: false),
                    HasPrawn = table.Column<bool>(type: "bit", nullable: false),
                    HasHam = table.Column<bool>(type: "bit", nullable: false),
                    HasBeef = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaPresets", x => x.PizzaId);
                });

            migrationBuilder.CreateTable(
                name: "PizzaOrderDetails",
                columns: table => new
                {
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaSize = table.Column<int>(type: "int", nullable: false),
                    PizzaSauce = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<float>(type: "real", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    HasCheese = table.Column<bool>(type: "bit", nullable: false),
                    HasPepperoni = table.Column<bool>(type: "bit", nullable: false),
                    HasMushroom = table.Column<bool>(type: "bit", nullable: false),
                    HasPineapple = table.Column<bool>(type: "bit", nullable: false),
                    HasTuna = table.Column<bool>(type: "bit", nullable: false),
                    HasPrawn = table.Column<bool>(type: "bit", nullable: false),
                    HasHam = table.Column<bool>(type: "bit", nullable: false),
                    HasBeef = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaOrderDetails", x => x.PizzaId);
                    table.ForeignKey(
                        name: "FK_PizzaOrderDetails_PizzaOrders_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "PizzaOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaOrderDetails");

            migrationBuilder.DropTable(
                name: "PizzaPresets");

            migrationBuilder.DropTable(
                name: "PizzaOrders");
        }
    }
}
