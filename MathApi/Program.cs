using MathLibrary;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();


app.MapOpenApi("swagger");

app.MapGet("/sum", (int a, int b) =>
    {
        return new Calculator().Sum(a, b);
    })
    .WithName("GetWeatherForecast");

app.Run();