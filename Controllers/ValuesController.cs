namespace Platform.Controllers {

using Microsoft.AspNetCore.Mvc;

[Route( "api/[controller]" )]
public class ValuesController : ControllerBase
{
    // GET api/values?api-version=1.0
    [HttpGet]
    public string Get() => $"Controller = {GetType().Name}\n";
}
}