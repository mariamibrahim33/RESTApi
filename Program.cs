using Microsoft.EntityFrameworkCore;
using RESTApi.Data;

// Set up the builder for services and configuration
var builder = WebApplication.CreateBuilder(args);

// Configure database context with SQLite
builder.Services.AddDbContext<AdventureWorksDbContext>(options =>
    options.UseSqlite("Data Source=AdventureWorks.db"));

// Register the controllers
builder.Services.AddControllers();

// Configure Swagger for testing REST APIs
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Set the server URL
builder.WebHost.UseUrls("http://localhost:8081");

// Build the application
var app = builder.Build();

// Enable Swagger only in development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware for HTTPS redirection
app.UseHttpsRedirection();

// Map ProductsController endpoints
app.MapControllers();

app.Run();



