using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Financeiro.Data.Configurations.ApplicationUsers;

[Table("usuarios")]
public class ApplicationUser : IdentityUser
{
    public string? Cpf { get; set; }
}