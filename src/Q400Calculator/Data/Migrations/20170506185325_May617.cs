using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q400Calculator.Data.Migrations
{
    public partial class May617 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inputs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altitude = table.Column<int>(nullable: false),
                    Icing = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Precipitation = table.Column<bool>(nullable: false),
                    RunwayDirection = table.Column<int>(nullable: false),
                    TakeoffTrueFalse = table.Column<bool>(nullable: false),
                    Temperature = table.Column<int>(nullable: false),
                    TripDistance = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    WindDegrees = table.Column<int>(nullable: false),
                    WindSpeed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inputs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inputs");
        }
    }
}
