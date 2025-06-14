var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var products = new[] { new { Id = 1, Name = "Laptop" }, new { Id = 2, Name = "Phone" } };

app.MapGet("/api/product", () =>
{
    return products;
})
.WithName("product");

app.Run();

