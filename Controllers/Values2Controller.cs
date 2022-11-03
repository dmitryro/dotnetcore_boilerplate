namespace Platform.Controllers {
using Microsoft.AspNetCore.Mvc;

[Route( "api/values" )]
public class Values2Controller : ControllerBase
{
    // GET api/values?api-version=2.0
    [HttpGet]
    public string Get() => $"Controller = {GetType().Name}\n";
}
}