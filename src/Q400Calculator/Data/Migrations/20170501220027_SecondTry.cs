using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q400Calculator.Data.Migrations
{
    public partial class SecondTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TakeoffFlaps5Above5Below20Data",
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
                    table.PrimaryKey("PK_TakeoffFlaps5Above5Below20Data", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TakeoffFlaps5Above5Below20Data");
        }
    }
}
