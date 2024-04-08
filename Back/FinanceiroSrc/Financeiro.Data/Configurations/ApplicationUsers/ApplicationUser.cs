using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Financeiro.Data.Configurations.ApplicationUsers;

public class ApplicationUser : IdentityUser
{
    [Key]
    public string? Cpf { get; set; }
}