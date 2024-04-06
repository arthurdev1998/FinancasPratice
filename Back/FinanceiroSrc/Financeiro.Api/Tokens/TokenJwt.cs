using System.IdentityModel.Tokens.Jwt;

namespace Financeiro.Api.Tokens;

public class TokenJwt
{
    //Token em si
    private JwtSecurityToken token;

    internal TokenJwt(JwtSecurityToken token)
    {
        this.token = token;
    }

    // Data de expiracao do token
    public DateTime ValidTo => token.ValidTo;

    //o valor do toke em string
    public string Value => new JwtSecurityTokenHandler().WriteToken(this.token);
}
