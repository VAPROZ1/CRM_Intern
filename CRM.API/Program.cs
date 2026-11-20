using CRM.Business.Abstract;
using CRM.Business.Concrete;
using CRM.DataAccess;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IMusteriService, MusteriManager>();
builder.Services.AddScoped<IFirmaService, FirmaManager>();
builder.Services.AddDbContext<CrmDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUrunService, UrunManager>();
builder.Services.AddScoped<ITeklifService, TeklifManager>();
builder.Services.AddScoped<ITeklifKalemiService, TeklifKalemiManager>();
builder.Services.AddScoped<IAktiviteService, AktiviteManager>();
builder.Services.AddScoped<IDestekTalebiService, DestekTalebiManager>();
builder.Services.AddScoped<INotService, NotManager>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
