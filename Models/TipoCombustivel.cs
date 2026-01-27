using System.ComponentModel.DataAnnotations;

namespace CRUD_CSHARP.Models;

public enum TipoCombustivel
{
    [Display(Name = "Selecione")]
    NaoInformada = 0,

    [Display(Name = "Gasolina")]
    Ciclomotor = 1,

    [Display(Name = "Etanol")]
    Motocicleta = 2,

    [Display(Name = "Diesel")]
    VeiculoLeve = 3,

    [Display(Name = "GNV")]
    Utilitario = 4,

    [Display(Name = "Eletrico")]
    VeiculoPesado = 5,
}

