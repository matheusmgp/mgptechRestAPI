using Microsoft.EntityFrameworkCore.Migrations;

namespace mgptechRestAPI.Infra.Migrations
{
    public partial class columnsrename7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ambiente_Ambiente_AmbienteId1",
                table: "Ambiente");

            migrationBuilder.DropIndex(
                name: "IX_Ambiente_AmbienteId1",
                table: "Ambiente");

            migrationBuilder.DropColumn(
                name: "AmbienteId1",
                table: "Ambiente");

            migrationBuilder.DropColumn(
                name: "ambiente_id",
                table: "Ambiente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmbienteId1",
                table: "Ambiente",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ambiente_id",
                table: "Ambiente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ambiente_AmbienteId1",
                table: "Ambiente",
                column: "AmbienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ambiente_Ambiente_AmbienteId1",
                table: "Ambiente",
                column: "AmbienteId1",
                principalTable: "Ambiente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
