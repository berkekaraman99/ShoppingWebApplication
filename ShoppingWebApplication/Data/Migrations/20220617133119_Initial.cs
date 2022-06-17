using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingWebApplication.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Colour",
                columns: table => new
                {
                    ColourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColourName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colour", x => x.ColourId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColourId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Colour_ColourId",
                        column: x => x.ColourId,
                        principalTable: "Colour",
                        principalColumn: "ColourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Tişört" },
                    { 2, "Şort" },
                    { 3, "Gömlek" },
                    { 4, "Eşofman" },
                    { 5, "Pantolon" },
                    { 6, "Ceket" },
                    { 7, "Jeans" },
                    { 8, "Yelek" },
                    { 9, "Kazak" },
                    { 10, "Mont" },
                    { 11, "Sweatshirt" },
                    { 12, "Takım Elbise" }
                });

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "ColourId", "ColourName" },
                values: new object[,]
                {
                    { 1, "Blue" },
                    { 2, "Red" },
                    { 3, "Green" },
                    { 4, "Brown" },
                    { 5, "Purple" },
                    { 6, "Black" },
                    { 7, "Turquiose" },
                    { 8, "Orange" },
                    { 9, "Yellow" },
                    { 10, "Pink" },
                    { 11, "Gray" },
                    { 12, "Beige" },
                    { 13, "Khaki" },
                    { 14, "Ecru" },
                    { 15, "Navy Blue" },
                    { 16, "Indigo" },
                    { 17, "Camel" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "ColourId", "Description", "ImagePath", "Price", "ProductName", "Supplier" },
                values: new object[,]
                {
                    { 1, 1, 6, "Slim Fit Bisiklet Yaka Tişört", "https://cdn.dsmcdn.com/ty328/product/media/images/20220209/18/47636736/357341652/3/3_org_zoom.jpg", 99.900000000000006, "Kısa Kollu Tişört", "Defacto" },
                    { 2, 2, 12, "Regular Fit Şort", "https://cdn.dsmcdn.com/ty320/product/media/images/20220203/11/42832809/305563350/2/2_org_zoom.jpg", 105.98999999999999, "Şort", "TRENDYOL MAN" },
                    { 3, 3, 2, "Ekoseli Oduncu Gömliği", "http://www.madmext.com/Uploads/UrunResimleri/buyuk/madmext-kirmizi-oduncu-gomlek-4950-0df7f-.jpg", 176.99000000000001, "Oduncu Gömleği", "Madmext" },
                    { 4, 7, 6, "Comfort Slim Fit Jean Pantolon", "https://cdn.dsmcdn.com/mnresize/1200/1800/ty314/product/media/images/20220131/11/39570345/129997989/1/1_org_zoom.jpg", 125.98999999999999, "Kot Pantolon", "Avva" },
                    { 5, 11, 6, "Basic Sweatshirt", "https://cdn.dsmcdn.com/ty95/product/media/images/20210403/20/fb2e760a/12547721/1/1_org_zoom.jpg", 119.98999999999999, "Sweatshirt", "New Balance" },
                    { 6, 6, 6, "Fermuarlı Süet Ceket", "https://cdn.dsmcdn.com/ty252/product/media/images/20211125/11/111687527/63549559/1/1_org_zoom.jpg", 175.99000000000001, "Ceket", "Densmood" },
                    { 7, 9, 15, "Lacivert-Bordo Çizgili Standart Fit Bisiklet Yaka Kazak", "https://cdn.dsmcdn.com/ty259/product/media/images/20211129/14/1161911/325212774/1/1_org_zoom.jpg", 78.989999999999995, "Kazak", "Altınyıldız Classics" },
                    { 8, 10, 15, "Mecan Pass Interchange Mont", "https://cdn.dsmcdn.com/ty65/product/media/images/20210205/11/60148635/137692619/1/1_org_zoom.jpg", 4120.9899999999998, "Mont", "Columbia" },
                    { 9, 5, 1, "Martin Vintage Mavi Jean Pantolon", "https://cdn.dsmcdn.com/ty452/product/media/images/20220610/19/123995093/266410610/1/1_org_zoom.jpg", 295.99000000000001, "Pantolon", "Mavi" },
                    { 10, 12, 12, "Bej Slim Fit Kırlangıc Yaka Kruvaze Takım Elbise", "https://cdn.dsmcdn.com/ty396/product/media/images/20220413/19/90390826/447432467/1/1_org_zoom.jpg", 1231.99, "Takım Elbise", "Mcr" },
                    { 11, 8, 6, "Bej Slim Fit Kırlangıc Yaka Kruvaze Takım Elbise", "https://cdn.dsmcdn.com/ty326/product/media/images/20220206/7/45556933/146921262/1/1_org_zoom.jpg", 250.99000000000001, "Yelek", "Danger" },
                    { 12, 4, 11, "Regular Fit Lastik Paçalı Eşofman Altı", "https://cdn.dsmcdn.com/ty433/product/media/images/20220518/16/113231020/61562287/2/2_org_zoom.jpg", 89.989999999999995, "Eşofman", "Trendyol Man" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ColourId",
                table: "Product",
                column: "ColourId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Colour");
        }
    }
}
