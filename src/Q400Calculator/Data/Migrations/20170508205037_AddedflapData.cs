using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q400Calculator.Data.Migrations
{
    public partial class AddedflapData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlapData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cold0V2 = table.Column<int>(nullable: false),
                    Cold0Vr = table.Column<int>(nullable: false),
                    Cold10000V2 = table.Column<int>(nullable: false),
                    Cold10000Vr = table.Column<int>(nullable: false),
                    Cold2000V2 = table.Column<int>(nullable: false),
                    Cold2000Vr = table.Column<int>(nullable: false),
                    Cold4000V2 = table.Column<int>(nullable: false),
                    Cold4000Vr = table.Column<int>(nullable: false),
                    Cold6000V2 = table.Column<int>(nullable: false),
                    Cold6000Vr = table.Column<int>(nullable: false),
                    Cold8000V2 = table.Column<int>(nullable: false),
                    Cold8000Vr = table.Column<int>(nullable: false),
                    Hot0V2 = table.Column<int>(nullable: false),
                    Hot0Vr = table.Column<int>(nullable: false),
                    Hot10000V2 = table.Column<int>(nullable: false),
                    Hot10000Vr = table.Column<int>(nullable: false),
                    Hot2000V2 = table.Column<int>(nullable: false),
                    Hot2000Vr = table.Column<int>(nullable: false),
                    Hot4000V2 = table.Column<int>(nullable: false),
                    Hot4000Vr = table.Column<int>(nullable: false),
                    Hot6000V2 = table.Column<int>(nullable: false),
                    Hot6000Vr = table.Column<int>(nullable: false),
                    Hot8000V2 = table.Column<int>(nullable: false),
                    Hot8000Vr = table.Column<int>(nullable: false),
                    InputsID = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlapData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlapData_Inputs_InputsID",
                        column: x => x.InputsID,
                        principalTable: "Inputs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlapData_InputsID",
                table: "FlapData",
                column: "InputsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlapData");
        }
    }
}
