﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Superheros.Data.Migrations
{
    public partial class AddedIdfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Superheros",
                table: "Superheros");

            migrationBuilder.AlterColumn<string>(
                name: "SuperheroName",
                table: "Superheros",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Superheros",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Superheros",
                table: "Superheros",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Superheros",
                table: "Superheros");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Superheros");

            migrationBuilder.AlterColumn<string>(
                name: "SuperheroName",
                table: "Superheros",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Superheros",
                table: "Superheros",
                column: "SuperheroName");
        }
    }
}
