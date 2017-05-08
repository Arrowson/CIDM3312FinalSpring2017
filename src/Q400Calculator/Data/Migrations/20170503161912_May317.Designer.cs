using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Q400Calculator.Data;

namespace Q400Calculator.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170503161912_May317")]
    partial class May317
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Q400Calculator.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Q400Calculator.Models.ClimbData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Vclmb");

                    b.Property<int>("Vfri10");

                    b.Property<int>("Vfri15");

                    b.Property<int>("Vfri5");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("ClimbData");
                });

            modelBuilder.Entity("Q400Calculator.Models.LandingFlaps10", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("VApp");

                    b.Property<int>("VRef");

                    b.Property<int>("Vga");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("LandingFlaps10");
                });

            modelBuilder.Entity("Q400Calculator.Models.LandingFlaps15", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("VApp");

                    b.Property<int>("VRef");

                    b.Property<int>("Vga");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("LandingFlaps15");
                });

            modelBuilder.Entity("Q400Calculator.Models.LandingFlaps35", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("VApp");

                    b.Property<int>("VRef");

                    b.Property<int>("Vga");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("LandingFlaps35");
                });

            modelBuilder.Entity("Q400Calculator.Models.LandingFlaps5", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("VApp");

                    b.Property<int>("VRef");

                    b.Property<int>("Vga");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("LandingFlaps5");
                });

            modelBuilder.Entity("Q400Calculator.Models.TakeoffFlaps10Above20", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("V20");

                    b.Property<int>("V22000");

                    b.Property<int>("V24000");

                    b.Property<int>("V26000");

                    b.Property<int>("V28000");

                    b.Property<int>("Vr0");

                    b.Property<int>("Vr10000");

                    b.Property<int>("Vr2000");

                    b.Property<int>("Vr4000");

                    b.Property<int>("Vr6000");

                    b.Property<int>("Vr8000");

                    b.Property<int>("Weight");

                    b.Property<int>("v210000");

                    b.HasKey("Id");

                    b.ToTable("TakeoffFlaps10Above20");
                });

            modelBuilder.Entity("Q400Calculator.Models.TakeoffFlaps10Below20Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("V20");

                    b.Property<int>("V22000");

                    b.Property<int>("V24000");

                    b.Property<int>("V26000");

                    b.Property<int>("V28000");

                    b.Property<int>("Vr0");

                    b.Property<int>("Vr10000");

                    b.Property<int>("Vr2000");

                    b.Property<int>("Vr4000");

                    b.Property<int>("Vr6000");

                    b.Property<int>("Vr8000");

                    b.Property<int>("Weight");

                    b.Property<int>("v210000");

                    b.HasKey("Id");

                    b.ToTable("TakeoffFlaps10Below20");
                });

            modelBuilder.Entity("Q400Calculator.Models.TakeoffFlaps15Above20", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("V20");

                    b.Property<int>("V22000");

                    b.Property<int>("V24000");

                    b.Property<int>("V26000");

                    b.Property<int>("V28000");

                    b.Property<int>("Vr0");

                    b.Property<int>("Vr10000");

                    b.Property<int>("Vr2000");

                    b.Property<int>("Vr4000");

                    b.Property<int>("Vr6000");

                    b.Property<int>("Vr8000");

                    b.Property<int>("Weight");

                    b.Property<int>("v210000");

                    b.HasKey("Id");

                    b.ToTable("TakeoffFlaps15Above20");
                });

            modelBuilder.Entity("Q400Calculator.Models.TakeoffFlaps15Below20Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("V20");

                    b.Property<int>("V22000");

                    b.Property<int>("V24000");

                    b.Property<int>("V26000");

                    b.Property<int>("V28000");

                    b.Property<int>("Vr0");

                    b.Property<int>("Vr10000");

                    b.Property<int>("Vr2000");

                    b.Property<int>("Vr4000");

                    b.Property<int>("Vr6000");

                    b.Property<int>("Vr8000");

                    b.Property<int>("Weight");

                    b.Property<int>("v210000");

                    b.HasKey("Id");

                    b.ToTable("TakeoffFlpas15Below20");
                });

            modelBuilder.Entity("Q400Calculator.Models.TakeoffFlaps5Above20Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("V20");

                    b.Property<int>("V22000");

                    b.Property<int>("V24000");

                    b.Property<int>("V26000");

                    b.Property<int>("V28000");

                    b.Property<int>("Vr0");

                    b.Property<int>("Vr10000");

                    b.Property<int>("Vr2000");

                    b.Property<int>("Vr4000");

                    b.Property<int>("Vr6000");

                    b.Property<int>("Vr8000");

                    b.Property<int>("Weight");

                    b.Property<int>("v210000");

                    b.HasKey("Id");

                    b.ToTable("TakeoffFlaps5Above20");
                });

            modelBuilder.Entity("Q400Calculator.Models.TakeoffFlaps5Above5Below20Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("V20");

                    b.Property<int>("V22000");

                    b.Property<int>("V24000");

                    b.Property<int>("V26000");

                    b.Property<int>("V28000");

                    b.Property<int>("Vr0");

                    b.Property<int>("Vr10000");

                    b.Property<int>("Vr2000");

                    b.Property<int>("Vr4000");

                    b.Property<int>("Vr6000");

                    b.Property<int>("Vr8000");

                    b.Property<int>("Weight");

                    b.Property<int>("v210000");

                    b.HasKey("Id");

                    b.ToTable("TakeoffFlaps5Above5Below20Data");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Q400Calculator.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Q400Calculator.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Q400Calculator.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
