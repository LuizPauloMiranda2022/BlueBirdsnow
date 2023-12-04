using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueBirdSnowboardingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoSnowboardingMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Snowboard",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Snowboard_MarcaId",
                table: "Snowboard",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Snowboard_Marca_MarcaId",
                table: "Snowboard",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Snowboard_Marca_MarcaId",
                table: "Snowboard");

            migrationBuilder.DropIndex(
                name: "IX_Snowboard_MarcaId",
                table: "Snowboard");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Snowboard");
        }
    }
}
