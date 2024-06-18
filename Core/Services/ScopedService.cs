using Core.Domain.Contracts;

namespace Core.Services;

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