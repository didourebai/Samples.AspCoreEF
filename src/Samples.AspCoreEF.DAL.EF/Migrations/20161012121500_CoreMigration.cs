using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Samples.AspCoreEF.DAL.EF.Migrations
{
    public partial class CoreMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AssignedToId = table.Column<int>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    State = table.Column<byte>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Persons_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AssignedToId",
                table: "Tasks",
                column: "AssignedToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
