using System;
using System.ComponentModel.DataAnnotations;

namespace BlueBirdSnowboardingApp.models;

public class Snowboard
{
    [Key]
	public int Snowboardid { get; set; }

    [Required(ErrorMessage ="Mandatory Field")]
    [StringLength(50)]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Required(ErrorMessage = "Mandatory Field")]
    [StringLength(200)]
    public string Descricao { get; set; }
    public string ImagemUri { get; set; }


    [Required(ErrorMessage = "Mandatory Field")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }

    public bool EntregaExpressa { get; set; }
    public string EntregaExpressaFormatada => EntregaExpressa ? "sim" : "Nao";

    [Required(ErrorMessage = "Mandatory Field")]
    [DisplayFormat(DataFormatString = "{0: MMMM \\o\\f yyyy}")]
    public DateTime DataCadastro { get; set; }

}

