var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/{id}/{ext}", (string id, string ext) => Results.Ok($"B: {id}, {ext}"));

app.Run();
