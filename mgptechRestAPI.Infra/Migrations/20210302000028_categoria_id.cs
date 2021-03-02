using Microsoft.EntityFrameworkCore.Migrations;

namespace mgptechRestAPI.Infra.Migrations
{
    public partial class categoria_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoria_Categoria_categoria_id",
                table: "SubCategoria");

            migrationBuilder.DropIndex(
                name: "IX_SubCategoria_categoria_id",
                table: "SubCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
