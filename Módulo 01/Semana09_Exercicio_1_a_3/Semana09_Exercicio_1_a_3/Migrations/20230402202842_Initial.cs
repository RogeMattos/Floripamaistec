﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Semana09_Exercicio_1_a_3.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Medico = table.Column<int>(type: "int", nullable: false),
                    DData_Parto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario_Parto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parto", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Parto_Medico",
                        column: x => x.Id_Medico,
                        principalTable: "Medico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bebe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso_Nascimento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Id_Mae = table.Column<int>(type: "int", nullable: false),
                    Id_Parto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebe", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Bebe_Mae",
                        column: x => x.Id_Mae,
                        principalTable: "Mae",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Bebe_Parto",
                        column: x => x.Id_Parto,
                        principalTable: "Parto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Id_Mae",
                table: "Bebe",
                column: "Id_Mae");

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Id_Parto",
                table: "Bebe",
                column: "Id_Parto");

            migrationBuilder.CreateIndex(
                name: "IX_Parto_Id_Medico",
                table: "Parto",
                column: "Id_Medico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebe");

            migrationBuilder.DropTable(
                name: "Mae");

            migrationBuilder.DropTable(
                name: "Parto");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
