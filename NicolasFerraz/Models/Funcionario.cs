namespace API.Models;

public class Funcionario
{
    public int FuncionarioId { get; set; }
    public string? Nome { get; set; }
    public int? CPF {get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.Now;
}