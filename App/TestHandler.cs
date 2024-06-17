using DependenceInjection.Domain.Contracts;

namespace DependenceInjection.App;

public class TestHandler : ITestService
{
    private readonly IScopedService _scoped;
    private readonly ITransientService _transient;

    public TestHandler(IScopedService scoped, ITransientService transient)
    {
        _scoped = scoped;
        _transient = transient;
    }

    public string Test()
    {
        var scoped = _scoped.Handle();
        var transient = _transient.Handle();
        return  $"Scoped are created once por request: {scoped} ; Transient are created new everytime: {transient}";
    }
}