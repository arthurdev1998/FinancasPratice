namespace Financeiro.Common.Notifications;

public class Notification
{
    public Notification ()
    {
        Notificacoes = [];
    }

    public string NomePropriedade { get; set; } = string.Empty;
    public string? Mensagem { get; set; } = string.Empty;
    public List<Notification> Notificacoes { get; set; }

    public bool ValidarPropriedadeString( string? valor, string nomePropriedade)
    {
        if(string.IsNullOrEmpty(valor) || string.IsNullOrWhiteSpace(valor))
        {
            Notificacoes.Add(new Notification
            {
                NomePropriedade = nomePropriedade,
                Mensagem = valor
            });

            return false;
        }

        return true;
    }
}