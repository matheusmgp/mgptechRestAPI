using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mgptechRestAPI.Infra.Migrations
{
    public partial class chamadosependencias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chamado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protocolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFechamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmbienteId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FilialId = table.Column<int>(type: "int", nullable: false),
                    UserFinishId = table.Column<int>(type: "int", nullable: false),
                    UserRedirectId = table.Column<int>(type: "int", nullable: false),
                    SetorId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamado_Ambiente_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Chamado_Filial_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Chamado_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Chamado_User_UserFinishId",
                        column: x => x.UserFinishId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Chamado_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Chamado_User_UserRedirectId",
                        column: x => x.UserRedirectId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Pendencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solucao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserFinishId = table.Column<int>(type: "int", nullable: false),
                    ChamadoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    SubCategoriaId = table.Column<int>(type: "int", nullable: false),
                    CanalComunicacaoId = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFechamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmbienteId = table.Column<int>(type: "int", nullable: false),
                    PendenciaImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendencia_Ambiente_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pendencia_CanalComunicacao_CanalComunicacaoId",
                        column: x => x.CanalComunicacaoId,
                        principalTable: "CanalComunicacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pendencia_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pendencia_Chamado_ChamadoId",
                        column: x => x.ChamadoId,
                        principalTable: "Chamado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pendencia_SubCategoria_SubCategoriaId",
                        column: x => x.SubCategoriaId,
                        principalTable: "SubCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pendencia_User_UserFinishId",
                        column: x => x.UserFinishId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pendencia_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_AmbienteId",
                table: "Chamado",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_FilialId",
                table: "Chamado",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_SetorId",
                table: "Chamado",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_UserFinishId",
                table: "Chamado",
                column: "UserFinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_UserId",
                table: "Chamado",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_UserRedirectId",
                table: "Chamado",
                column: "UserRedirectId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_AmbienteId",
                table: "Pendencia",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_CanalComunicacaoId",
                table: "Pendencia",
                column: "CanalComunicacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_CategoriaId",
                table: "Pendencia",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_ChamadoId",
                table: "Pendencia",
                column: "ChamadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_SubCategoriaId",
                table: "Pendencia",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_UserFinishId",
                table: "Pendencia",
                column: "UserFinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_UserId",
                table: "Pendencia",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pendencia");

            migrationBuilder.DropTable(
                name: "Chamado");
        }
    }
}
