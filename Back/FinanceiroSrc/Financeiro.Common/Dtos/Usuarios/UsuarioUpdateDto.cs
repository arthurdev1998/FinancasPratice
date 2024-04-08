namespace Financeiro.Common.Dtos.Usuarios;

public class UsuarioUpdateDto
{
    public Guid Guid { get; set; }
    public string? Email { get; set; }
    public string? Cpf { get; set; }
}