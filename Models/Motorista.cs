using System.ComponentModel.DataAnnotations;

namespace CRUD_CSHARP.Models;

public class Motorista
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [StringLength(14)]
    public string Cpf { get; set; } = string.Empty;

    [Required]
    [StringLength(9)]
    public string Cnh { get; set; } = string.Empty;

    [Phone]
    [StringLength(20)]
    public string? Telefone { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DataNascimento { get; set; }
}
