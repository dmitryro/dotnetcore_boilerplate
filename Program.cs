using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Platform.Services;

[assembly: Microsoft.AspNetCore.Mvc.ApiController]

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen (c =>
  {
   // other configs;
    c.ResolveConflictingActions (apiDescriptions => apiDescriptions.First ());
  });
/*

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.DisableImplicitFromServicesParameters = true;
});
*/
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
  {
     c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
  });

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
//app.UseAuthorization();
app.MapControllers();
app.Run();
