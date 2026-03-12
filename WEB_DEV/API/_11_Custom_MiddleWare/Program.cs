using _11_Custom_MiddleWare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Configure the HTTP request pipeline.
app.UseMiddleware<TrimMiddleware>();


app.UseAuthorization();


app.MapControllers();

app.Run();
