using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingWebApplication.Models;

namespace ShoppingWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ShoppingWebApplication.Models.Product>? Product { get; set; }
        public DbSet<ShoppingWebApplication.Models.Category>? Category { get; set; }
        public DbSet<ShoppingWebApplication.Models.Colour>? Colour { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Colour>().HasData(
                new Colour { ColourId = 1, ColourName = "Blue" },
                new Colour { ColourId = 2, ColourName = "Red" },
                new Colour { ColourId = 3, ColourName = "Green" },
                new Colour { ColourId = 4, ColourName = "Brown" },
                new Colour { ColourId = 5, ColourName = "Purple" },
                new Colour { ColourId = 6, ColourName = "Black" },
                new Colour { ColourId = 7, ColourName = "Turquiose" },
                new Colour { ColourId = 8, ColourName = "Orange" },
                new Colour { ColourId = 9, ColourName = "Yellow" },
                new Colour { ColourId = 10, ColourName = "Pink" },
                new Colour { ColourId = 11, ColourName = "Gray" },
                new Colour { ColourId = 12, ColourName = "Beige" },
                new Colour { ColourId = 13, ColourName = "Khaki" },
                new Colour { ColourId = 14, ColourName = "Ecru" },
                new Colour { ColourId = 15, ColourName = "Navy Blue" },
                new Colour { ColourId = 16, ColourName = "Indigo" },
                new Colour { ColourId = 17, ColourName = "Camel" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Tişört" },
                new Category { CategoryId = 2, CategoryName = "Şort" },
                new Category { CategoryId = 3, CategoryName = "Gömlek" },
                new Category { CategoryId = 4, CategoryName = "Eşofman" },
                new Category { CategoryId = 5, CategoryName = "Pantolon" },
                new Category { CategoryId = 6, CategoryName = "Ceket" },
                new Category { CategoryId = 7, CategoryName = "Jeans" },
                new Category { CategoryId = 8, CategoryName = "Yelek" },
                new Category { CategoryId = 9, CategoryName = "Kazak" },
                new Category { CategoryId = 10, CategoryName = "Mont" },
                new Category { CategoryId = 11, CategoryName = "Sweatshirt" },
                new Category { CategoryId = 12, CategoryName = "Takım Elbise" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Kısa Kollu Tişört",
                    Price = "99.99",
                    ColourId = 6,
                    Description = "Slim Fit Bisiklet Yaka Tişört",
                    CategoryId = 1,
                    Supplier = "Defacto",
                    ImagePath = "https://cdn.dsmcdn.com/ty328/product/media/images/20220209/18/47636736/357341652/3/3_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Şort",
                    Price = "105.99",
                    ColourId = 12,
                    Description = "Regular Fit Şort",
                    Supplier = "TRENDYOL MAN",
                    CategoryId = 2,
                    ImagePath = "https://cdn.dsmcdn.com/ty320/product/media/images/20220203/11/42832809/305563350/2/2_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Oduncu Gömleği",
                    Price = "176.99",
                    ColourId = 2,
                    Description = "Ekoseli Oduncu Gömliği",
                    Supplier= "Madmext",
                    CategoryId = 3,
                    ImagePath = "http://www.madmext.com/Uploads/UrunResimleri/buyuk/madmext-kirmizi-oduncu-gomlek-4950-0df7f-.jpg"
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Kot Pantolon",
                    Price = "125.99",
                    ColourId = 6,
                    Description = "Comfort Slim Fit Jean Pantolon",
                    Supplier= "Avva",
                    CategoryId = 7,
                    ImagePath = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty314/product/media/images/20220131/11/39570345/129997989/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Sweatshirt",
                    Price = "119.99",
                    ColourId = 6,
                    Description = "Basic Sweatshirt",
                    Supplier= "New Balance",
                    CategoryId = 11,
                    ImagePath = "https://cdn.dsmcdn.com/ty95/product/media/images/20210403/20/fb2e760a/12547721/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Ceket",
                    Price = "175.99",
                    ColourId = 6,
                    Description = "Fermuarlı Süet Ceket",
                    Supplier= "Densmood",
                    CategoryId = 6,
                    ImagePath = "https://cdn.dsmcdn.com/ty252/product/media/images/20211125/11/111687527/63549559/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "Kazak",
                    Price = "78.99",
                    ColourId = 15,
                    Description = "Lacivert-Bordo Çizgili Standart Fit Bisiklet Yaka Kazak",
                    Supplier= "Altınyıldız Classics",
                    CategoryId = 9,
                    ImagePath = "https://cdn.dsmcdn.com/ty259/product/media/images/20211129/14/1161911/325212774/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Mont",
                    Price = "4120.99",
                    ColourId = 15,
                    Description = "Mecan Pass Interchange Mont",
                    Supplier= "Columbia",
                    CategoryId = 10,
                    ImagePath = "https://cdn.dsmcdn.com/ty65/product/media/images/20210205/11/60148635/137692619/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "Pantolon",
                    Price = "295.99",
                    ColourId = 1,
                    Description = "Martin Vintage Mavi Jean Pantolon",
                    Supplier= "Mavi",
                    CategoryId = 5,
                    ImagePath = "https://cdn.dsmcdn.com/ty452/product/media/images/20220610/19/123995093/266410610/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "Takım Elbise",
                    Price = "1231.99",
                    ColourId = 12,
                    Description = "Bej Slim Fit Kırlangıc Yaka Kruvaze Takım Elbise",
                    Supplier= "Mcr",
                    CategoryId = 12,
                    ImagePath = "https://cdn.dsmcdn.com/ty396/product/media/images/20220413/19/90390826/447432467/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 11,
                    ProductName = "Yelek",
                    Price = "250.99",
                    ColourId = 6,
                    Description = "Bej Slim Fit Kırlangıc Yaka Kruvaze Takım Elbise",
                    Supplier= "Danger",
                    CategoryId = 8,
                    ImagePath = "https://cdn.dsmcdn.com/ty326/product/media/images/20220206/7/45556933/146921262/1/1_org_zoom.jpg"
                },
                new Product
                {
                    ProductId = 12,
                    ProductName = "Eşofman",
                    Price = "89.99",
                    ColourId = 11,
                    Description = "Regular Fit Lastik Paçalı Eşofman Altı",
                    Supplier= "Trendyol Man",
                    CategoryId = 4,
                    ImagePath = "https://cdn.dsmcdn.com/ty433/product/media/images/20220518/16/113231020/61562287/2/2_org_zoom.jpg"
                }

                );
        }

        
    }
}