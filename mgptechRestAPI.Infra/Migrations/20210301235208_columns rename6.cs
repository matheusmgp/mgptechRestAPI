using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mgptechRestAPI.Infra.Migrations
{
    public partial class columnsrename6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambiente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_fantasia = table.Column<string>(type: "varchar(50)", nullable: true),
                    razao_social = table.Column<string>(type: "varchar(50)", nullable: true),
                    cnpj = table.Column<string>(type: "varchar(14)", nullable: true),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false),
                    AmbienteId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambiente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ambiente_Ambiente_AmbienteId1",
                        column: x => x.AmbienteId1,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    telefone = table.Column<string>(type: "varchar(15)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", nullable: true),
                    observacao = table.Column<string>(type: "text", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CanalComunicacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanalComunicacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CanalComunicacao_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Filial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cnpj = table.Column<string>(type: "varchar(14)", nullable: true),
                    razao_social = table.Column<string>(type: "varchar(50)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    nome_fantasia = table.Column<string>(type: "varchar(50)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filial_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Procedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao_value = table.Column<string>(type: "varchar(300)", nullable: true),
                    descricao = table.Column<string>(type: "varchar(300)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Procedimento_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    tempo = table.Column<string>(type: "varchar(10)", nullable: true),
                    tempo_rapido = table.Column<string>(type: "varchar(10)", nullable: true),
                    tempo_medio = table.Column<string>(type: "varchar(10)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setor_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", nullable: true),
                    senha = table.Column<string>(type: "varchar(200)", nullable: true),
                    token = table.Column<string>(type: "text", nullable: true),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Categoria_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Chamado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    protocolo = table.Column<string>(type: "varchar(50)", nullable: true),
                    data_abertura = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    data_fechamento = table.Column<DateTime>(type: "dateTime2", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    filial_id = table.Column<int>(type: "int", nullable: false),
                    user_finish_id = table.Column<int>(type: "int", nullable: true),
                    user_redirect_id = table.Column<int>(type: "int", nullable: true),
                    setor_id = table.Column<int>(type: "int", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamado_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Chamado_User_user_finish_id",
                        column: x => x.user_finish_id,
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
                    descricao = table.Column<string>(type: "text", nullable: true),
                    solucao = table.Column<string>(type: "text", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    user_finish_id = table.Column<int>(type: "int", nullable: true),
                    chamado_id = table.Column<int>(type: "int", nullable: false),
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    subCategoria_id = table.Column<int>(type: "int", nullable: false),
                    canal_id = table.Column<int>(type: "int", nullable: false),
                    imagem = table.Column<string>(type: "varchar(200)", nullable: true),
                    status = table.Column<string>(type: "varchar(1)", nullable: true),
                    data_abertura = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    data_fechamento = table.Column<DateTime>(type: "dateTime2", nullable: true),
                    pendencia_imagem = table.Column<string>(type: "varchar(50)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    ambiente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendencia_Ambiente_ambiente_id",
                        column: x => x.ambiente_id,
                        principalTable: "Ambiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pendencia_Chamado_chamado_id",
                        column: x => x.chamado_id,
                        principalTable: "Chamado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pendencia_User_user_finish_id",
                        column: x => x.user_finish_id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_ambiente_id",
                table: "Agendas",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ambiente_AmbienteId1",
                table: "Ambiente",
                column: "AmbienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_CanalComunicacao_ambiente_id",
                table: "CanalComunicacao",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_ambiente_id",
                table: "Categoria",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_ambiente_id",
                table: "Chamado",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_user_finish_id",
                table: "Chamado",
                column: "user_finish_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ambiente_id",
                table: "Cliente",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Filial_ambiente_id",
                table: "Filial",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_ambiente_id",
                table: "Pendencia",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_chamado_id",
                table: "Pendencia",
                column: "chamado_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencia_user_finish_id",
                table: "Pendencia",
                column: "user_finish_id");

            migrationBuilder.CreateIndex(
                name: "IX_Procedimento_ambiente_id",
                table: "Procedimento",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ambiente_id",
                table: "Role",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Setor_ambiente_id",
                table: "Setor",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_ambiente_id",
                table: "SubCategoria",
                column: "ambiente_id");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_categoria_id",
                table: "SubCategoria",
                column: "categoria_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_ambiente_id",
                table: "User",
                column: "ambiente_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "CanalComunicacao");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Filial");

            migrationBuilder.DropTable(
                name: "Pendencia");

            migrationBuilder.DropTable(
                name: "Procedimento");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "SubCategoria");

            migrationBuilder.DropTable(
                name: "Chamado");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Ambiente");
        }
    }
}
