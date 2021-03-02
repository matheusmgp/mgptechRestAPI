using Microsoft.EntityFrameworkCore.Migrations;

namespace mgptechRestAPI.Infra.Migrations
{
    public partial class subcategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamado_User_user_finish_id",
                table: "Chamado");

            migrationBuilder.DropIndex(
                name: "IX_Chamado_user_finish_id",
                table: "Chamado");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_categoria_id",
                table: "SubCategoria",
                column: "categoria_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoria_Categoria_categoria_id",
                table: "SubCategoria",
                column: "categoria_id",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoria_Categoria_categoria_id",
                table: "SubCategoria");

            migrationBuilder.DropIndex(
                name: "IX_SubCategoria_categoria_id",
                table: "SubCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_user_finish_id",
                table: "Chamado",
                column: "user_finish_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamado_User_user_finish_id",
                table: "Chamado",
                column: "user_finish_id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
