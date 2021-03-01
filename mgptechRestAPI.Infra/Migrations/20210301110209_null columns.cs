using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mgptechRestAPI.Infra.Migrations
{
    public partial class nullcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamado_User_UserFinishId",
                table: "Chamado");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamado_User_UserRedirectId",
                table: "Chamado");

            migrationBuilder.DropForeignKey(
                name: "FK_Pendencia_User_UserFinishId",
                table: "Pendencia");

            migrationBuilder.AlterColumn<int>(
                name: "UserFinishId",
                table: "Pendencia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFechamento",
                table: "Pendencia",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserRedirectId",
                table: "Chamado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserFinishId",
                table: "Chamado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFechamento",
                table: "Chamado",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamado_User_UserFinishId",
                table: "Chamado",
                column: "UserFinishId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chamado_User_UserRedirectId",
                table: "Chamado",
                column: "UserRedirectId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pendencia_User_UserFinishId",
                table: "Pendencia",
                column: "UserFinishId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamado_User_UserFinishId",
                table: "Chamado");

            migrationBuilder.DropForeignKey(
                name: "FK_Chamado_User_UserRedirectId",
                table: "Chamado");

            migrationBuilder.DropForeignKey(
                name: "FK_Pendencia_User_UserFinishId",
                table: "Pendencia");

            migrationBuilder.AlterColumn<int>(
                name: "UserFinishId",
                table: "Pendencia",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFechamento",
                table: "Pendencia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserRedirectId",
                table: "Chamado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserFinishId",
                table: "Chamado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFechamento",
                table: "Chamado",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chamado_User_UserFinishId",
                table: "Chamado",
                column: "UserFinishId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chamado_User_UserRedirectId",
                table: "Chamado",
                column: "UserRedirectId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pendencia_User_UserFinishId",
                table: "Pendencia",
                column: "UserFinishId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
