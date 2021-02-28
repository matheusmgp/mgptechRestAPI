using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mgptechRestAPI.Infra.Migrations
{
    public partial class canalComunicacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CanalComunicacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmbienteId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanalComunicacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CanalComunicacao_Ambiente_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanalComunicacao_AmbienteId",
                table: "CanalComunicacao",
                column: "AmbienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanalComunicacao");
        }
    }
}
