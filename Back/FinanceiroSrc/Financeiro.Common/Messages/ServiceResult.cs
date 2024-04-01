namespace Financeiro.Common.Messages;

public class ServiceResult<T>
{
    public T? Data { get; set; }   
    public List<string> Messages { get; set; }  = new List<string>();
    public bool HasError { get; set; }

    public ServiceResult()
    {}

    public ServiceResult(T? data)
    {
        Data = data;
    }

    public ServiceResult(string str)
    {
        Messages.Add(str);
    }

    public static ServiceResults ServicResult(string str)
    {
        return new ServiceResults();
    }

    public class ServiceResults : ServiceResult<object>
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        public ServiceResults() : base(null)
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        {
        }

        public ServiceResults(string str): base(str)
        {
        }
    }
}