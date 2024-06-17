using DependenceInjection.App;
using DependenceInjection.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DependenceInjection.Controllers;

[ApiController]
public class ApiController
{

    private readonly IScopedService _service;
    private readonly ITransientService _transient;
    private readonly ISingletonService _singleton;
    private readonly ITestService _test;

    public ApiController(IScopedService service, ITransientService transient, ISingletonService singleton, ITestService test)
    {
        _service = service;
        _transient = transient;
        _singleton = singleton;
        _test = test;
    }
    
    [Route("api/test")]
    [HttpGet]
    public string Handle()
    {
        var scoped = _service.Handle();
        var transient = _transient.Handle();
        var singleton = _singleton.Handle();


        var test =  _test.Test();
        
        
        string msg = $" {test} \n\n Scoped are created once por request: {scoped} ; Transient are created new everytime: {transient}, Singleton: {singleton}";
        return msg;
    }
}