namespace Platform.Controllers {

using Microsoft.AspNetCore.Mvc;

[Route( "api/[controller]" )]
public class MultiVersionedController : ControllerBase
{
    [HttpGet]
    public string Get() => "Version ";

    [HttpGet]
    public string GetV2( ) => "Version ";
}
}