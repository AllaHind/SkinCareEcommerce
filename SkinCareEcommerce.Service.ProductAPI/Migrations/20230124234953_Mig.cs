using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkinCareEcommerce.Service.ProductAPI.Migrations
{
    public partial class Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "ImageURL", "Price", "ProductName" },
                values: new object[] { 1, "categorie1", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrnd2XJIKTIcFojhx2yEY56Gn8Q-h0IprUAA&usqp=CAU", 15.0, "ChaiseBoisMassif" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "ImageURL", "Price", "ProductName" },
                values: new object[] { 2, "categorie1", "https://images.ctfassets.net/qfo47mrl3zhx/76QmX0yOLyTl8vNVWpiRvC/e36535dd123b08af7125069c7c845f58/CVS_SH_proactive_1-bybanner.jpg", 15.0, "CLEANSE And Polish" });
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
