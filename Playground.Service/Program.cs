var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Basic middleware setup
app.UseRouting();

// Map endpoints
app.MapGet("/", () => "Hello from ASP.NET Core Empty Project!");
app.MapGet("/info", () => new { 
    Name = "Playground.Service", 
    Framework = ".NET 9.0",
    Environment = app.Environment.EnvironmentName,
    DateTime = DateTime.UtcNow
});
app.MapHealthChecks("/health");

app.Run();
