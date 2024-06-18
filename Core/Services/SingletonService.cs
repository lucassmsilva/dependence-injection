using Core.Domain.Contracts;

namespace Core.Services;

public class SingletonService : ISingletonService
{
    public Guid _guid;

    public SingletonService()
    {
        _guid = Guid.NewGuid();
    }
    public string Handle()
    {
        return _guid.ToString();
    }
}