using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class Emily : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "TakeoffFlaps5Above5Below20Data",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "TakeoffFlaps5Above20",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "TakeoffFlpas15Below20",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "TakeoffFlaps15Above20",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "TakeoffFlaps10Below20",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "TakeoffFlaps10Above20",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "LandingFlaps5",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "LandingFlaps35",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "LandingFlaps15",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "LandingFlaps10",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlapsSettings",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InputsID",
                table: "ClimbData",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TakeoffFlaps5Above5Below20Data_InputsID",
                table: "TakeoffFlaps5Above5Below20Data",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_TakeoffFlaps5Above20_InputsID",
                table: "TakeoffFlaps5Above20",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_TakeoffFlpas15Below20_InputsID",
                table: "TakeoffFlpas15Below20",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_TakeoffFlaps15Above20_InputsID",
                table: "TakeoffFlaps15Above20",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_TakeoffFlaps10Below20_InputsID",
                table: "TakeoffFlaps10Below20",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_TakeoffFlaps10Above20_InputsID",
                table: "TakeoffFlaps10Above20",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_LandingFlaps5_InputsID",
                table: "LandingFlaps5",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_LandingFlaps35_InputsID",
                table: "LandingFlaps35",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_LandingFlaps15_InputsID",
                table: "LandingFlaps15",
                column: "InputsID");

            migrationBuilder.CreateIndex(
                name: "IX_LandingFlaps10_InputsID",
                table: "LandingFlaps10",
                column: "InputsID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Inputs",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_ClimbData_InputsID",
                table: "ClimbData",
                column: "InputsID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClimbData_Inputs_InputsID",
                table: "ClimbData",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandingFlaps10_Inputs_InputsID",
                table: "LandingFlaps10",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandingFlaps15_Inputs_InputsID",
                table: "LandingFlaps15",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandingFlaps35_Inputs_InputsID",
                table: "LandingFlaps35",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandingFlaps5_Inputs_InputsID",
                table: "LandingFlaps5",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoffFlaps10Above20_Inputs_InputsID",
                table: "TakeoffFlaps10Above20",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoffFlaps10Below20_Inputs_InputsID",
                table: "TakeoffFlaps10Below20",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoffFlaps15Above20_Inputs_InputsID",
                table: "TakeoffFlaps15Above20",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoffFlpas15Below20_Inputs_InputsID",
                table: "TakeoffFlpas15Below20",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoffFlaps5Above20_Inputs_InputsID",
                table: "TakeoffFlaps5Above20",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoffFlaps5Above5Below20Data_Inputs_InputsID",
                table: "TakeoffFlaps5Above5Below20Data",
                column: "InputsID",
                principalTable: "Inputs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClimbData_Inputs_InputsID",
                table: "ClimbData");

            migrationBuilder.DropForeignKey(
                name: "FK_LandingFlaps10_Inputs_InputsID",
                table: "LandingFlaps10");

            migrationBuilder.DropForeignKey(
                name: "FK_LandingFlaps15_Inputs_InputsID",
                table: "LandingFlaps15");

            migrationBuilder.DropForeignKey(
                name: "FK_LandingFlaps35_Inputs_InputsID",
                table: "LandingFlaps35");

            migrationBuilder.DropForeignKey(
                name: "FK_LandingFlaps5_Inputs_InputsID",
                table: "LandingFlaps5");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoffFlaps10Above20_Inputs_InputsID",
                table: "TakeoffFlaps10Above20");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoffFlaps10Below20_Inputs_InputsID",
                table: "TakeoffFlaps10Below20");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoffFlaps15Above20_Inputs_InputsID",
                table: "TakeoffFlaps15Above20");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoffFlpas15Below20_Inputs_InputsID",
                table: "TakeoffFlpas15Below20");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoffFlaps5Above20_Inputs_InputsID",
                table: "TakeoffFlaps5Above20");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoffFlaps5Above5Below20Data_Inputs_InputsID",
                table: "TakeoffFlaps5Above5Below20Data");

            migrationBuilder.DropIndex(
                name: "IX_TakeoffFlaps5Above5Below20Data_InputsID",
                table: "TakeoffFlaps5Above5Below20Data");

            migrationBuilder.DropIndex(
                name: "IX_TakeoffFlaps5Above20_InputsID",
                table: "TakeoffFlaps5Above20");

            migrationBuilder.DropIndex(
                name: "IX_TakeoffFlpas15Below20_InputsID",
                table: "TakeoffFlpas15Below20");

            migrationBuilder.DropIndex(
                name: "IX_TakeoffFlaps15Above20_InputsID",
                table: "TakeoffFlaps15Above20");

            migrationBuilder.DropIndex(
                name: "IX_TakeoffFlaps10Below20_InputsID",
                table: "TakeoffFlaps10Below20");

            migrationBuilder.DropIndex(
                name: "IX_TakeoffFlaps10Above20_InputsID",
                table: "TakeoffFlaps10Above20");

            migrationBuilder.DropIndex(
                name: "IX_LandingFlaps5_InputsID",
                table: "LandingFlaps5");

            migrationBuilder.DropIndex(
                name: "IX_LandingFlaps35_InputsID",
                table: "LandingFlaps35");

            migrationBuilder.DropIndex(
                name: "IX_LandingFlaps15_InputsID",
                table: "LandingFlaps15");

            migrationBuilder.DropIndex(
                name: "IX_LandingFlaps10_InputsID",
                table: "LandingFlaps10");

            migrationBuilder.DropIndex(
                name: "IX_ClimbData_InputsID",
                table: "ClimbData");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "TakeoffFlaps5Above5Below20Data");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "TakeoffFlaps5Above20");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "TakeoffFlpas15Below20");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "TakeoffFlaps15Above20");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "TakeoffFlaps10Below20");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "TakeoffFlaps10Above20");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "LandingFlaps5");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "LandingFlaps35");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "LandingFlaps15");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "LandingFlaps10");

            migrationBuilder.DropColumn(
                name: "FlapsSettings",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "InputsID",
                table: "ClimbData");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Inputs",
                nullable: true);
        }
    }
}
