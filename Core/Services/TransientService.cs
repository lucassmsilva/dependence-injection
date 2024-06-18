
using Core.Domain.Contracts;

namespace Core.Services;


public class TransientService : ITransientService
{
    public Guid _guid;

    public TransientService()
    {
        _guid = Guid.NewGuid();
    }
    public string Handle()
    {
        return _guid.ToString();
    }
}