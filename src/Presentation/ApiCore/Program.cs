using Microsoft.EntityFrameworkCore;
using Persistence.Database;
using Application.ServiceRegistration;
using Persistence.ServiceRegistration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegistrationService();
builder.Services.PersistenceRegistrationService();
// Add services to the container.
builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
