using College.BLL;
using College.Core.Common;
using College.Core.Interfaces;
using College.SQLServerDAL;
using College.SQLServerDAL.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string _policyName = "AllowAll";

// Add services to the container.
builder.Services.AddCors(o => o.AddPolicy(_policyName, builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

// Adding EF Core
var connectionString = builder.Configuration[Constants.DataStore.SqlConnectionString];
builder.Services.AddDbContext<CollegeSqlDbContext>(o => o.UseSqlServer(connectionString));

// Application Services
builder.Services.AddScoped<IProfessorsSqlBll, ProfessorsSqlBll>();
builder.Services.AddScoped<IProfessorsSqlDal, ProfessorsSqlDal>();

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

app.UseCors(_policyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
