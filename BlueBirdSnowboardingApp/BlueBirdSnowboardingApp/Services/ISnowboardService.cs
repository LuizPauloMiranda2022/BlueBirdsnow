
using BlueBirdSnowboardingApp.models;

namespace BlueBirdSnowboardingApp.Services;

public interface ISnowboardService
{
    public IList<Snowboard> ObterTodos();
    public Snowboard Obter(int id);
    void Inlcuir(Snowboard snowboard);
    void Alterar(Snowboard snowboard);
    void Excluir(int snowboardid);
    IList<Marca> ObterTodasMarcas();
}

