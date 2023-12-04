 using BlueBirdSnowboardingApp.models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueBirdSnowboardingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SnowboardingDbContext();

                context.Marca.AddRange(ObterCargaInicialMarca());
                context.SaveChanges();

        }
         
        private IList<Marca>ObterCargaInicialMarca()
        {
            return new List<Marca>()
            {
                new Marca(){Descricao= "Burton"},
                new Marca(){Descricao= "Salomon"},
                new Marca(){Descricao= "K2"},
                new Marca(){Descricao= "LibTech"},
            };
        }
        
    }
}
