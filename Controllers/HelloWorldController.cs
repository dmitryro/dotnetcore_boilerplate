namespace Platform.Controllers {
using Microsoft.AspNetCore.Mvc;


[Route( "api/[controller]" )]
public class HelloWorldController : ControllerBase
{
    // GET api/helloworld
    [HttpGet]
    public IActionResult Get() => Ok( new { Controller = GetType().Name } );

    // GET api/helloworld/{id}
    [HttpGet( "{id:int}" )]
    public IActionResult Get(int id) => Ok( new { Controller = GetType().Name, Id = id } );

    // POST api/helloworld
    [HttpPost]
    public IActionResult Post( ) => CreatedAtAction( nameof( Get ), new { id = 42 }, null );
}
}