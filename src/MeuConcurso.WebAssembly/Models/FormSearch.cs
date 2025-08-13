using System.ComponentModel.DataAnnotations;

namespace MeuConcurso.WebAssembly.Models;

public class FormSearch
{
    [Required(ErrorMessage = "O termo de pesquisa é obrigatório.")]
    [StringLength(30, ErrorMessage = "Termo de pesquisa deve ter no máximo 30 caracteres.", MinimumLength = 3)]
    public string? Search { get; set; }
}
