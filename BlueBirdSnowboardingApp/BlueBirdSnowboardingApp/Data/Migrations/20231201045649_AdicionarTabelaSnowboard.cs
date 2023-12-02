using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueBirdSnowboardingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaSnowboard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Snowboard",
                columns: table => new
                {
                    Snowboardid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ImagemUri = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<double>(type: "REAL", nullable: false),
                    EntregaExpressa = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snowboard", x => x.Snowboardid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Snowboard");
        }
    }
}
