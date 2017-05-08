using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q400Calculator.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LandingFlaps10",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VApp = table.Column<int>(nullable: false),
                    VRef = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandingFlaps10", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandingFlaps15",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VApp = table.Column<int>(nullable: false),
                    VRef = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandingFlaps15", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandingFlaps35",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VApp = table.Column<int>(nullable: false),
                    VRef = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandingFlaps35", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandingFlaps5",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VApp = table.Column<int>(nullable: false),
                    VRef = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandingFlaps5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakeoffFlaps10Above20",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    V20 = table.Column<int>(nullable: false),
                    V22000 = table.Column<int>(nullable: false),
                    V24000 = table.Column<int>(nullable: false),
                    V26000 = table.Column<int>(nullable: false),
                    V28000 = table.Column<int>(nullable: false),
                    Vr0 = table.Column<int>(nullable: false),
                    Vr10000 = table.Column<int>(nullable: false),
                    Vr2000 = table.Column<int>(nullable: false),
                    Vr4000 = table.Column<int>(nullable: false),
                    Vr6000 = table.Column<int>(nullable: false),
                    Vr8000 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    v210000 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeoffFlaps10Above20", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakeoffFlaps10Below20",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    V20 = table.Column<int>(nullable: false),
                    V22000 = table.Column<int>(nullable: false),
                    V24000 = table.Column<int>(nullable: false),
                    V26000 = table.Column<int>(nullable: false),
                    V28000 = table.Column<int>(nullable: false),
                    Vr0 = table.Column<int>(nullable: false),
                    Vr10000 = table.Column<int>(nullable: false),
                    Vr2000 = table.Column<int>(nullable: false),
                    Vr4000 = table.Column<int>(nullable: false),
                    Vr6000 = table.Column<int>(nullable: false),
                    Vr8000 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    v210000 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeoffFlaps10Below20", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakeoffFlaps15Above20",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    V20 = table.Column<int>(nullable: false),
                    V22000 = table.Column<int>(nullable: false),
                    V24000 = table.Column<int>(nullable: false),
                    V26000 = table.Column<int>(nullable: false),
                    V28000 = table.Column<int>(nullable: false),
                    Vr0 = table.Column<int>(nullable: false),
                    Vr10000 = table.Column<int>(nullable: false),
                    Vr2000 = table.Column<int>(nullable: false),
                    Vr4000 = table.Column<int>(nullable: false),
                    Vr6000 = table.Column<int>(nullable: false),
                    Vr8000 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    v210000 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeoffFlaps15Above20", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakeoffFlpas15Below20",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    V20 = table.Column<int>(nullable: false),
                    V22000 = table.Column<int>(nullable: false),
                    V24000 = table.Column<int>(nullable: false),
                    V26000 = table.Column<int>(nullable: false),
                    V28000 = table.Column<int>(nullable: false),
                    Vr0 = table.Column<int>(nullable: false),
                    Vr10000 = table.Column<int>(nullable: false),
                    Vr2000 = table.Column<int>(nullable: false),
                    Vr4000 = table.Column<int>(nullable: false),
                    Vr6000 = table.Column<int>(nullable: false),
                    Vr8000 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    v210000 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeoffFlpas15Below20", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakeoffFlaps5Above20",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    V20 = table.Column<int>(nullable: false),
                    V22000 = table.Column<int>(nullable: false),
                    V24000 = table.Column<int>(nullable: false),
                    V26000 = table.Column<int>(nullable: false),
                    V28000 = table.Column<int>(nullable: false),
                    Vr0 = table.Column<int>(nullable: false),
                    Vr10000 = table.Column<int>(nullable: false),
                    Vr2000 = table.Column<int>(nullable: false),
                    Vr4000 = table.Column<int>(nullable: false),
                    Vr6000 = table.Column<int>(nullable: false),
                    Vr8000 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    v210000 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeoffFlaps5Above20", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandingFlaps10");

            migrationBuilder.DropTable(
                name: "LandingFlaps15");

            migrationBuilder.DropTable(
                name: "LandingFlaps35");

            migrationBuilder.DropTable(
                name: "LandingFlaps5");

            migrationBuilder.DropTable(
                name: "TakeoffFlaps10Above20");

            migrationBuilder.DropTable(
                name: "TakeoffFlaps10Below20");

            migrationBuilder.DropTable(
                name: "TakeoffFlaps15Above20");

            migrationBuilder.DropTable(
                name: "TakeoffFlpas15Below20");

            migrationBuilder.DropTable(
                name: "TakeoffFlaps5Above20");
        }
    }
}
