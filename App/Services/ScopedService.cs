using DependenceInjection.Domain.Contracts;

namespace DependenceInjection.App.Services;

public class ScopedService : IScopedService
{
    public Guid _guid;

    public ScopedService()
    {
        _guid = Guid.NewGuid();
    }
    public string Handle()
    {
        return _guid.ToString();
    }
}