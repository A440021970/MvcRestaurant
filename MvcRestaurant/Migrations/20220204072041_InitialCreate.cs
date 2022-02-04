using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcRestaurant.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platillo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDelPlatillo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiempoDePreparacion = table.Column<int>(type: "int", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platillo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Platillo");
        }
    }
}
