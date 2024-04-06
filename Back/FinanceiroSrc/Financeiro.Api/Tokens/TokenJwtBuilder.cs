using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace Financeiro.Api.Tokens;

public class TokenJwtBuilder
{
    private SecurityKey securityKey = null; // a chave de seguranca // pode ser simetrica ou assimetrica
    private string subject = ""; // indica o assunto do token
    private string issuer = ""; // indica o emissor do token
    private string audience = ""; // audiente indica quem deve consumir o token ou seja : "Empresa ou Api algo assim"
    private Dictionary<string, string> claims = new Dictionary<string, string>();
    private int expiryInMinutes = 5;

    public TokenJwtBuilder AddSecurityKey(SecurityKey securityKey)
    {
        this.securityKey = securityKey;
        return this;
    }

    public TokenJwtBuilder AddSubject(string subject)
    {
        this.subject = subject;
        return this;
    }

    public TokenJwtBuilder AddIssuer(string issuer)
    {
        this.issuer = issuer;
        return this;
    }

    public TokenJwtBuilder AddAudience(string audience)
    {
        this.audience = audience;
        return this;
    }

    public TokenJwtBuilder AddClaim(string type, string value)
    {
        this.claims.Add(type, value);
        return this;
    }

    public TokenJwtBuilder AddClaims(Dictionary<string, string> claims)
    {
        this.claims.Union(claims);
        return this;
    }

    public TokenJwtBuilder AddExpiry(int expiryInMinutes)
    {
        this.expiryInMinutes = expiryInMinutes;
        return this;
    }

    //Validacoes -> TO DO: isso deveria estar em outro lugar
    private void EnsureArguments()
    {
        if (this.securityKey == null)
            throw new ArgumentNullException("Security Key");

        if (string.IsNullOrEmpty(this.subject))
            throw new ArgumentNullException("Subject");

        if (string.IsNullOrEmpty(this.issuer))
            throw new ArgumentNullException("Issuer");

        if (string.IsNullOrEmpty(this.audience))
            throw new ArgumentNullException("Audience");
    }

    public TokenJwt Builder()
    {
        EnsureArguments();

        var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub,this.subject),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }.Union(this.claims.Select(item => new Claim(item.Key, item.Value)));

        var token = new JwtSecurityToken(
            issuer: this.issuer,
            audience: this.audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expiryInMinutes),
            signingCredentials: new SigningCredentials(
                                               this.securityKey,
                                               SecurityAlgorithms.HmacSha256)
            );

        return new TokenJwt(token);
    }
}