namespace Financeiro.Common.Messages;

public class MapperExtensionMessage
{
    public static T NotImplemented<T>()
    {
        var typeInterface = typeof(T).GetType();
        throw new ArgumentException($"nao implementado :{typeInterface.Name}");
    }
}