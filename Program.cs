using Microsoft.EntityFrameworkCore;
using NorthwindInventoryAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// This code block adds services to the container.
builder.Services.AddControllers(); // Registers controllers for the API.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dbcontext Connection String
builder.Services.AddDbContext<NorthwindContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("NorthwindDatabase")));

var app = builder.Build();

// This will configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
