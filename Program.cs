using CodeFirstRelation.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PatikaSecondDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();

app.Run();
