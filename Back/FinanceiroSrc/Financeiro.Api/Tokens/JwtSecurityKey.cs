using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Financeiro.Api.Tokens;

public class JwtSecurityKey
{
    //Cria uma chave simétrica -> serve tanto para criptografar quando descriptografar
    public static SymmetricSecurityKey Create(string secret)
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
    }
}