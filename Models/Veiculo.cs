using System.ComponentModel.DataAnnotations;

namespace CRUD_CSHARP.Models;

public class Veiculo
{
    public int Id { get; set; }

    [Required]
    [StringLength(8, MinimumLength = 7)]
    public string Placa { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "Selecione a Marca do Carro.")]
    [Display(Name = "Marca")]
    public MarcaCarro Marca { get; set; } = MarcaCarro.NaoInformada;

    [Required]
    [StringLength(60)]
    public string Modelo { get; set; } = string.Empty;

    [Range(1900, 2026)]
    public int? Ano { get; set; }

    [Required]
    [Range(10, 1000)]
    [Display(Name = "Capacidade Tanque (L)")]
    public decimal CapacidadeTanqueLitros { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Selecione O Tipo de Combustivel veículo.")]
    [Display(Name = "Tipo Combustivel")]
    public TipoCombustivel Combustivel { get; set; } = TipoCombustivel.NaoInformada;

    [Range(1, int.MaxValue, ErrorMessage = "Selecione a categoria do veículo.")]
    [Display(Name = "Categoria")]
    public CategoriaVeiculo Categoria { get; set; } = CategoriaVeiculo.NaoInformada;
}
