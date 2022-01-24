using Microsoft.EntityFrameworkCore;
using TicketManagementSystem.Infrastructure;
using TicketManagementSystem.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
var builder = WebApplication.CreateBuilder(args);
// gaa
// Add services to the container.
// Add services to the container.

builder.Services.AddDbContext<TicketManagementSystem.Infrastructure.TicketIssueDbContext>
(
    options =>
       options.UseSqlServer
       (
           connectionString: "server=(local);database=TicketIssueDb;integrated security=sspi"
       )
);


// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
Console.WriteLine("Hello World");
