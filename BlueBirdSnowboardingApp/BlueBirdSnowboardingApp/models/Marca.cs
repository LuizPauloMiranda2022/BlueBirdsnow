using System;
namespace BlueBirdSnowboardingApp.models;

public class Marca
{
	public int MarcaId { get; set; }
	public string Descricao { get; set; }

	public ICollection<Snowboard> Snowboardings { get; set; }
}

