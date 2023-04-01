using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using nine_night.Context;
using Microsoft.Extensions.Configuration;
using nine_night;
using Microsoft.Data.SqlClient;
using nine_night.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//設定連線
var connectionString = builder.Configuration.GetConnectionString("DB");
builder.Services.AddSingleton<SqlConnection>(_ => new SqlConnection(connectionString));

builder.Services.AddSingleton<UserDBService>();


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
