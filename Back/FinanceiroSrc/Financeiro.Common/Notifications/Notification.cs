namespace Financeiro.Common.Notifications;

public sealed class Notification
{
    public Notification ()
    {
        Notificacoes = [];
    }

    public string NomePropriedade { get; set; }
    public string Mensagem { get; set; }
    public List<Notification>? Notificacoes { get; set; }

    public bool ValidarPropriedadeString( string valor, string nomePropriedade)
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