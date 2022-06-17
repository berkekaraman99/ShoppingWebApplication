﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingWebApplication.Data;

#nullable disable

namespace ShoppingWebApplication.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220617133119_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ShoppingWebApplication.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Tişört"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Şort"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gömlek"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Eşofman"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Pantolon"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Ceket"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Jeans"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Yelek"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Kazak"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Mont"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Sweatshirt"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "Takım Elbise"
                        });
                });

            modelBuilder.Entity("ShoppingWebApplication.Models.Colour", b =>
                {
                    b.Property<int>("ColourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColourId"), 1L, 1);

                    b.Property<string>("ColourName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColourId");

                    b.ToTable("Colour");

                    b.HasData(
                        new
                        {
                            ColourId = 1,
                            ColourName = "Blue"
                        },
                        new
                        {
                            ColourId = 2,
                            ColourName = "Red"
                        },
                        new
                        {
                            ColourId = 3,
                            ColourName = "Green"
                        },
                        new
                        {
                            ColourId = 4,
                            ColourName = "Brown"
                        },
                        new
                        {
                            ColourId = 5,
                            ColourName = "Purple"
                        },
                        new
                        {
                            ColourId = 6,
                            ColourName = "Black"
                        },
                        new
                        {
                            ColourId = 7,
                            ColourName = "Turquiose"
                        },
                        new
                        {
                            ColourId = 8,
                            ColourName = "Orange"
                        },
                        new
                        {
                            ColourId = 9,
                            ColourName = "Yellow"
                        },
                        new
                        {
                            ColourId = 10,
                            ColourName = "Pink"
                        },
                        new
                        {
                            ColourId = 11,
                            ColourName = "Gray"
                        },
                        new
                        {
                            ColourId = 12,
                            ColourName = "Beige"
                        },
                        new
                        {
                            ColourId = 13,
                            ColourName = "Khaki"
                        },
                        new
                        {
                            ColourId = 14,
                            ColourName = "Ecru"
                        },
                        new
                        {
                            ColourId = 15,
                            ColourName = "Navy Blue"
                        },
                        new
                        {
                            ColourId = 16,
                            ColourName = "Indigo"
                        },
                        new
                        {
                            ColourId = 17,
                            ColourName = "Camel"
                        });
                });

            modelBuilder.Entity("ShoppingWebApplication.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColourId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColourId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ColourId = 6,
                            Description = "Slim Fit Bisiklet Yaka Tişört",
                            ImagePath = "https://cdn.dsmcdn.com/ty328/product/media/images/20220209/18/47636736/357341652/3/3_org_zoom.jpg",
                            Price = 99.900000000000006,
                            ProductName = "Kısa Kollu Tişört",
                            Supplier = "Defacto"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            ColourId = 12,
                            Description = "Regular Fit Şort",
                            ImagePath = "https://cdn.dsmcdn.com/ty320/product/media/images/20220203/11/42832809/305563350/2/2_org_zoom.jpg",
                            Price = 105.98999999999999,
                            ProductName = "Şort",
                            Supplier = "TRENDYOL MAN"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            ColourId = 2,
                            Description = "Ekoseli Oduncu Gömliği",
                            ImagePath = "http://www.madmext.com/Uploads/UrunResimleri/buyuk/madmext-kirmizi-oduncu-gomlek-4950-0df7f-.jpg",
                            Price = 176.99000000000001,
                            ProductName = "Oduncu Gömleği",
                            Supplier = "Madmext"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 7,
                            ColourId = 6,
                            Description = "Comfort Slim Fit Jean Pantolon",
                            ImagePath = "https://cdn.dsmcdn.com/mnresize/1200/1800/ty314/product/media/images/20220131/11/39570345/129997989/1/1_org_zoom.jpg",
                            Price = 125.98999999999999,
                            ProductName = "Kot Pantolon",
                            Supplier = "Avva"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 11,
                            ColourId = 6,
                            Description = "Basic Sweatshirt",
                            ImagePath = "https://cdn.dsmcdn.com/ty95/product/media/images/20210403/20/fb2e760a/12547721/1/1_org_zoom.jpg",
                            Price = 119.98999999999999,
                            ProductName = "Sweatshirt",
                            Supplier = "New Balance"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 6,
                            ColourId = 6,
                            Description = "Fermuarlı Süet Ceket",
                            ImagePath = "https://cdn.dsmcdn.com/ty252/product/media/images/20211125/11/111687527/63549559/1/1_org_zoom.jpg",
                            Price = 175.99000000000001,
                            ProductName = "Ceket",
                            Supplier = "Densmood"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 9,
                            ColourId = 15,
                            Description = "Lacivert-Bordo Çizgili Standart Fit Bisiklet Yaka Kazak",
                            ImagePath = "https://cdn.dsmcdn.com/ty259/product/media/images/20211129/14/1161911/325212774/1/1_org_zoom.jpg",
                            Price = 78.989999999999995,
                            ProductName = "Kazak",
                            Supplier = "Altınyıldız Classics"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 10,
                            ColourId = 15,
                            Description = "Mecan Pass Interchange Mont",
                            ImagePath = "https://cdn.dsmcdn.com/ty65/product/media/images/20210205/11/60148635/137692619/1/1_org_zoom.jpg",
                            Price = 4120.9899999999998,
                            ProductName = "Mont",
                            Supplier = "Columbia"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 5,
                            ColourId = 1,
                            Description = "Martin Vintage Mavi Jean Pantolon",
                            ImagePath = "https://cdn.dsmcdn.com/ty452/product/media/images/20220610/19/123995093/266410610/1/1_org_zoom.jpg",
                            Price = 295.99000000000001,
                            ProductName = "Pantolon",
                            Supplier = "Mavi"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 12,
                            ColourId = 12,
                            Description = "Bej Slim Fit Kırlangıc Yaka Kruvaze Takım Elbise",
                            ImagePath = "https://cdn.dsmcdn.com/ty396/product/media/images/20220413/19/90390826/447432467/1/1_org_zoom.jpg",
                            Price = 1231.99,
                            ProductName = "Takım Elbise",
                            Supplier = "Mcr"
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 8,
                            ColourId = 6,
                            Description = "Bej Slim Fit Kırlangıc Yaka Kruvaze Takım Elbise",
                            ImagePath = "https://cdn.dsmcdn.com/ty326/product/media/images/20220206/7/45556933/146921262/1/1_org_zoom.jpg",
                            Price = 250.99000000000001,
                            ProductName = "Yelek",
                            Supplier = "Danger"
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            ColourId = 11,
                            Description = "Regular Fit Lastik Paçalı Eşofman Altı",
                            ImagePath = "https://cdn.dsmcdn.com/ty433/product/media/images/20220518/16/113231020/61562287/2/2_org_zoom.jpg",
                            Price = 89.989999999999995,
                            ProductName = "Eşofman",
                            Supplier = "Trendyol Man"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShoppingWebApplication.Models.Product", b =>
                {
                    b.HasOne("ShoppingWebApplication.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingWebApplication.Models.Colour", "Colour")
                        .WithMany()
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Colour");
                });
#pragma warning restore 612, 618
        }
    }
}
