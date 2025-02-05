using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasASP.Migrations
{
    /// <inheritdoc />
    public partial class CreateListaTareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaTareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaTareas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListaTareasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_ListaTareas_ListaTareasId",
                        column: x => x.ListaTareasId,
                        principalTable: "ListaTareas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ListaTareasId",
                table: "Tarea",
                column: "ListaTareasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "ListaTareas");
        }
    }
}
