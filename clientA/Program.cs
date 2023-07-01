var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/{id}", (string id) => Results.Ok($"A: {id}"));

app.Run();