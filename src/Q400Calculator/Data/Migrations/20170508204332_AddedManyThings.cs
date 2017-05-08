using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class AddedManyThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTailwind",
                table: "Inputs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "V1",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "V2",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VClimb",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VFri",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vapp",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vga",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vr",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vref",
                table: "Inputs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "WindComponent",
                table: "Inputs",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTailwind",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "V1",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "V2",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "VClimb",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "VFri",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "Vapp",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "Vga",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "Vr",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "Vref",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "WindComponent",
                table: "Inputs");
        }
    }
}
