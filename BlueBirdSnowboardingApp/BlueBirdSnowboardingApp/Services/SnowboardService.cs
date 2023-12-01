using System;
using BlueBirdSnowboardingApp.models;

namespace BlueBirdSnowboardingApp.Services
{
	public class SnowboardService : ISnowboardService
	{


        public SnowboardService()
        {
            CarregarListaInicial();
        }

        private IList<Snowboard> _snowboards;

        private void CarregarListaInicial()
        {

            _snowboards = new List<Snowboard>()
        {
            new Snowboard
            {
                Snowboardid = 1,
                Nome = "Flyng V - 300",
                Descricao = "",
                ImagemUri = "/images/01.jpg",
                Preco = 450.00,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now

            },
             new Snowboard
            {
                Snowboardid = 2,
                Nome = "Flyng V - 500",
                Descricao = "",
                ImagemUri = "/images/02.jpg",
                Preco = 650.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },
             new Snowboard
            {
                Snowboardid = 3,
                Nome = "Ripcord",
                Descricao = "",
                ImagemUri = "/images/03.jpg",
                Preco = 500.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },
              new Snowboard
            {
                Snowboardid = 4,
                Nome = "Custom LPM",
                Descricao = "",
                ImagemUri = "/images/04.jpg",
                Preco = 450.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },
        };

        }


        public IList<Snowboard> ObterTodos() => _snowboards;
		

        public Snowboard Obter(int id) => ObterTodos().SingleOrDefault(item => item.Snowboardid == id);



        public void Inlcuir(Snowboard snowboard)
        {
            var proximoID = _snowboards.Max(item => item.Snowboardid) + 1;
            snowboard.Snowboardid = proximoID;
            _snowboards.Add(snowboard);


        }

        public void Alterar(Snowboard snowboard)   
        {
            var snowboardEncontrado = _snowboards.SingleOrDefault(item => item.Snowboardid == snowboard.Snowboardid);
            snowboardEncontrado.Descricao = snowboard.Descricao;
            snowboardEncontrado.Preco = snowboard.Preco;
            snowboardEncontrado.EntregaExpressa = snowboard.EntregaExpressa;
            snowboardEncontrado.DataCadastro = snowboard.DataCadastro;
            snowboardEncontrado.ImagemUri = snowboard.ImagemUri;
               

        }

        public void Excluir(int id)
        {
            var snowboardEncontrado = Obter(id);
            _snowboards.Remove(snowboardEncontrado);
        }

    }

    

}

