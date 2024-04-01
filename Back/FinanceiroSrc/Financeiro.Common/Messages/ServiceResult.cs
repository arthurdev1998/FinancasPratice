namespace Financeiro.Common.Messages;

public class ServiceResult<T>
{
    public T? Data { get; set; }   
    public List<string> ErrorList { get; set; }  = new List<string>();
    public bool HasError { get; set; }

    public ServiceResult()
    {
    }

    public ServiceResult(T data)
    {
        Data = data;
    }
}