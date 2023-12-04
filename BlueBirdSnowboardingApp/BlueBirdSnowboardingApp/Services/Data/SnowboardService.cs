using System;
using BlueBirdSnowboardingApp.Data;
using BlueBirdSnowboardingApp.models;

namespace BlueBirdSnowboardingApp.Services.Data;

public class SnowboardService:ISnowboardService
{
    private SnowboardingDbContext _context;

    public SnowboardService(SnowboardingDbContext context)
    {
        _context = context;
    }

    public void Alterar(Snowboard snowboard)
    {
        var snowboardingEncontrado = Obter(snowboard.Snowboardid);
        snowboardingEncontrado.Nome = snowboard.Nome;
        snowboardingEncontrado.Descricao = snowboard.Descricao;
        snowboardingEncontrado.Preco = snowboard.Preco;
        snowboardingEncontrado.ImagemUri = snowboard.ImagemUri;
        snowboardingEncontrado.EntregaExpressa = snowboard.EntregaExpressa;
        snowboardingEncontrado.DataCadastro = snowboardingEncontrado.DataCadastro;
        _ = _context.SaveChanges();

    }

    public void Excluir(int id)
    {
        var snowboardingEncontrado = Obter(id);
        _context.Snowboard.Remove(snowboardingEncontrado);
        _context.SaveChanges();
    }

    public void Inlcuir(Snowboard snowboard)
    {
        _context.Snowboard.Add(snowboard);
        _context.SaveChanges();
    }

    public Snowboard Obter(int id)
    {
        return _context.Snowboard.SingleOrDefault(item => item.Snowboardid == id);
    }

    public IList<Snowboard> ObterTodos()
    {
        return _context.Snowboard.ToList();
    }

    public IList<Marca> ObterTodasMarcas()
        => _context.Marca.ToList();
   
}

