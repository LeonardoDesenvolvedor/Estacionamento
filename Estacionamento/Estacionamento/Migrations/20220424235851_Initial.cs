using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_proprietario",
                columns: table => new
                {
                    cod_prop = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "text", maxLength: 15, nullable: false),
                    sobrenome = table.Column<string>(type: "text", maxLength: 35, nullable: false),
                    rg = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    data_Nasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cnh_categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_proprietario", x => x.cod_prop);
                });

            migrationBuilder.CreateTable(
                name: "tbl_veiculo",
                columns: table => new
                {
                    cod_veiculo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeV = table.Column<string>(type: "text", nullable: false),
                    corV = table.Column<string>(type: "text", nullable: false),
                    modeloV = table.Column<string>(type: "text", nullable: false),
                    placaV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    combustivel = table.Column<string>(type: "text", nullable: false),
                    cod_prop = table.Column<long>(type: "bigint", nullable: true),
                    Proprietariocod_prop = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_veiculo", x => x.cod_veiculo);
                    table.ForeignKey(
                        name: "FK_tbl_veiculo_tbl_proprietario_Proprietariocod_prop",
                        column: x => x.Proprietariocod_prop,
                        principalTable: "tbl_proprietario",
                        principalColumn: "cod_prop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_veiculo_Proprietariocod_prop",
                table: "tbl_veiculo",
                column: "Proprietariocod_prop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_veiculo");

            migrationBuilder.DropTable(
                name: "tbl_proprietario");
        }
    }
}
