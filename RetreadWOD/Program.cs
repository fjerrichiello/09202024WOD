using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SemanticKernel;
using RetreadWOD.Endpoints;
using RetreadWOD.Persistence;
using RetreadWOD.Persistence.Models;


var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;


configuration.AddEnvironmentVariables();

var apiKey = configuration["AI:OpenAI:ApiKey"];
services.AddOpenAIChatCompletion("gpt-3", apiKey!);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
services.AddAuthorizationBuilder();

services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

builder.Services.AddIdentityCore<ApiUser>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddApiEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapIdentityApi<ApiUser>();

app.MapChatEndpoints();

app.UseHttpsRedirection();

app.Run();