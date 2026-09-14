using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uc_10_Ryan_Relacionamentos_Descricao_00500.Migrations
{
    /// <inheritdoc />
    public partial class CorrigeTabelaConsulta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_TipoConsulta_TipoConsultaId",
                table: "Consulta");

            migrationBuilder.AlterColumn<int>(
                name: "TipoConsultaId",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_TipoConsulta_TipoConsultaId",
                table: "Consulta",
                column: "TipoConsultaId",
                principalTable: "TipoConsulta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_TipoConsulta_TipoConsultaId",
                table: "Consulta");

            migrationBuilder.AlterColumn<int>(
                name: "TipoConsultaId",
                table: "Consulta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_TipoConsulta_TipoConsultaId",
                table: "Consulta",
                column: "TipoConsultaId",
                principalTable: "TipoConsulta",
                principalColumn: "Id");
        }
    }
}
