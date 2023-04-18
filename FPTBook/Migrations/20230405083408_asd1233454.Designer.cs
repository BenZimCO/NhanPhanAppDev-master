﻿// <auto-generated />
using System;
using FPTBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FPTBook.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230405083408_asd1233454")]
    partial class asd1233454
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FPTBook.Models.AppUserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("StoreId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "201",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4c0b2c25-0592-4d89-abea-72f173d115cf",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nguyen Van Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEuSEuhr2H7Yu084j73f1XuHF6U3YJ2yiANK4SG2qyIBjaR8/hIIzh69/m3RRVpYZw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2ee8bf94-c1c9-4ecb-8eba-227b408a394f",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "202",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5221c015-46f5-4471-a595-f5d178500dd7",
                            Email = "storeowner1@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nguyen Van store",
                            LockoutEnabled = false,
                            NormalizedEmail = "STOREOWNER1@GMAIL.COM",
                            NormalizedUserName = "STOREOWNER1@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECpfyVNZ3LxMyZztIWtF5F8r1Zn0dDkw7JcjFYsrMhvJt6caKdddB/p10Ap4kJYikw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "29e4462a-6ba8-4bd5-bcc6-0a7c9625a059",
                            TwoFactorEnabled = false,
                            UserName = "storeowner1@gmail.com"
                        },
                        new
                        {
                            Id = "203",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9dc9fe07-8008-44de-b4dd-691f38334419",
                            Email = "storeowner2@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nguyen Van store",
                            LockoutEnabled = false,
                            NormalizedEmail = "STOREOWNER2@GMAIL.COM",
                            NormalizedUserName = "STOREOWNER2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGpZ1ir2tIZCRZD8D3gJyLlqtIS99PUxM17+cNml9H5wflX+rkS5h0hb6+r1otVQ3g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c507917a-a7bc-4a3c-bdc8-63671e9acae9",
                            TwoFactorEnabled = false,
                            UserName = "storeowner2@gmail.com"
                        },
                        new
                        {
                            Id = "204",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c056b108-52d5-4a5d-a128-04690c84b836",
                            Email = "customer@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nguyen Van customer",
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@GMAIL.COM",
                            NormalizedUserName = "CUSTOMER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOzOnRguSUoeZiM+BVMLBQ/xDWEQbajax+gi33A86tO5+nxcT+jz0iWndRX1zCcg3w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9ff9c952-25bc-4016-8f1e-92ae45308b24",
                            TwoFactorEnabled = false,
                            UserName = "customer@gmail.com"
                        });
                });

            modelBuilder.Entity("FPTBook.Models.BookModel", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN");

                    b.HasIndex("CategoryID");

                    b.HasIndex("StoreID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ISBN = "9780751565355",
                            Author = "J. K. Rowling",
                            CategoryID = "101",
                            Cost = 24.09,
                            Description = @"Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.

Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.",
                            ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680630725/9780751565355_gflcmw.jpg",
                            StoreID = "101",
                            Title = "Harry Potter and the Cursed Child - Parts I & II : The Official Script Book of the Original West End Production"
                        },
                        new
                        {
                            ISBN = "9780751565351231235",
                            Author = "J Rowling",
                            CategoryID = "101",
                            Cost = 123.09399999999999,
                            Description = @"Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.

Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.",
                            ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680630725/9780751565355_gflcmw.jpg",
                            StoreID = "101",
                            Title = "The Official Script Book of the Original West End Production"
                        },
                        new
                        {
                            ISBN = "9781471156267",
                            Author = "Colleen Hoover",
                            CategoryID = "102",
                            Cost = 16.329999999999998,
                            Description = "A brave and heartbreaking novel that digs its claws into you and doesn't let go, long after you've finished it' Anna Todd, author of the After series 'A glorious and touching read, a forever keeper' USA Today 'Will break your heart while filling you with hope' Sarah Pekkanen, Perfect Neighbors SOMETIMES THE ONE WHO LOVES YOU IS THE ONE WHO HURTS YOU THE MOST. Lily hasn't always had it easy, but that's never stopped her from working hard for the life she wants. She's come a long way from the small town in Maine where she grew up - she graduated from college, moved to Boston, and started her own business. So when she feels a spark with a gorgeous neurosurgeon named Ryle Kincaid, everything in Lily's life suddenly seems almost too good to be true. Ryle is assertive, stubborn, maybe even a little arrogant. He's also sensitive, brilliant, and has a total soft spot for Lily, but Ryle's complete aversion to relationships is disturbing. Even as Lily finds herself becoming the exception to his 'no dating' rule, she can't help but wonder what made him that way in the first place. As questions about her new relationship overwhelm her, so do thoughts of Atlas Corrigan - her first love and a link to the past she left behind. He was her kindred spirit, her protector. When Atlas suddenly reappears, everything Lily has built with Ryle is threatened. With this bold and deeply personal novel, It Ends With Us is a heart-wrenching story and an unforgettable tale of love that comes at the ultimate price.",
                            ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680631224/3_gaxnnl.jpg",
                            StoreID = "102",
                            Title = "It Ends With Us: The most heartbreaking novel you'll ever read : The most heartbreaking novel you'll ever read"
                        },
                        new
                        {
                            ISBN = "9781408708989",
                            Author = "J. K. Rowling",
                            CategoryID = "102",
                            Cost = 21.260000000000002,
                            Description = @"J.K. Rowling's screenwriting debut is captured in this exciting hardcover edition of the Fantastic Beasts and Where to Find Them screenplay.
When Magizoologist Newt Scamander arrives in New York, he intends his stay to be just a brief stopover. However, when his magical case is misplaced and some of Newt's fantastic beasts escape, it spells trouble for everyone...Fantastic Beasts and Where to Find Them marks the screenwriting debut of J.K. Rowling, author of the beloved and internationally bestselling Harry Potter books. Featuring a cast of remarkable characters, this is epic, adventure-packed storytelling at its very best. Whether an existing fan or new to the wizarding world, this is a perfect addition to any reader's bookshelf.",
                            ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680630919/2_oou1a0.jpg",
                            StoreID = "102",
                            Title = "Fantastic Beasts and Where to Find Them : The Original Screenplay"
                        });
                });

            modelBuilder.Entity("FPTBook.Models.CartModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookISBN");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FPTBook.Models.CategoryModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = "101",
                            Name = "Fantasy literature"
                        },
                        new
                        {
                            Id = "102",
                            Name = "Romance"
                        });
                });

            modelBuilder.Entity("FPTBook.Models.OrderDetailModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookISBN");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FPTBook.Models.OrderModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserModelId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FPTBook.Models.RoleModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "101",
                            ConcurrencyStamp = "a60470f7-ff1a-44fe-b241-9fcf46c824a0",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "102",
                            ConcurrencyStamp = "ebc25e83-3d66-4db0-8c2a-516bcef1fef6",
                            Name = "StoreOwner",
                            NormalizedName = "STOREOWNER"
                        },
                        new
                        {
                            Id = "103",
                            ConcurrencyStamp = "2c3c6b48-597c-416a-933d-e0fe52d45917",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("FPTBook.Models.StoreModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreOwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = "101",
                            Name = "Book Depository",
                            StoreOwnerId = "102"
                        },
                        new
                        {
                            Id = "102",
                            Name = "Books Wagon",
                            StoreOwnerId = "103"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "201",
                            RoleId = "101"
                        },
                        new
                        {
                            UserId = "202",
                            RoleId = "102"
                        },
                        new
                        {
                            UserId = "203",
                            RoleId = "102"
                        },
                        new
                        {
                            UserId = "204",
                            RoleId = "103"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("FPTBook.Models.AppUserModel", b =>
                {
                    b.HasOne("FPTBook.Models.StoreModel", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("FPTBook.Models.BookModel", b =>
                {
                    b.HasOne("FPTBook.Models.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("FPTBook.Models.StoreModel", "Store")
                        .WithMany()
                        .HasForeignKey("StoreID");
                });

            modelBuilder.Entity("FPTBook.Models.CartModel", b =>
                {
                    b.HasOne("FPTBook.Models.BookModel", "Book")
                        .WithMany()
                        .HasForeignKey("BookISBN");

                    b.HasOne("FPTBook.Models.AppUserModel", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FPTBook.Models.OrderDetailModel", b =>
                {
                    b.HasOne("FPTBook.Models.BookModel", "Book")
                        .WithMany()
                        .HasForeignKey("BookISBN");

                    b.HasOne("FPTBook.Models.OrderModel", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("FPTBook.Models.OrderModel", b =>
                {
                    b.HasOne("FPTBook.Models.AppUserModel", null)
                        .WithMany("Orders")
                        .HasForeignKey("AppUserModelId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("FPTBook.Models.RoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FPTBook.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FPTBook.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("FPTBook.Models.RoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTBook.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FPTBook.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}