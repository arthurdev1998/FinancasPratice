using Financeiro.Data.Configurations.ApplicationUsers;
using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Configurations.Categorias;
using Financeiro.Data.Configurations.Despesas;
using Financeiro.Data.Configurations.SistemasFinanceiros;
using Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(
                   builder.Configuration.GetConnectionString("DefaultConnection")));

// instalar o pacote :  Microsoft.AspNetCore.Identity.UI nuget package
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped(typeof(InterfaceGeneric<>), typeof(RepositoryGenerics<>));
builder.Services.AddScoped<InterfaceCategoria, CategoriaRepositorio>();
builder.Services.AddScoped<IDespesaRepository, DespesaRepository>();
builder.Services.AddScoped<ISistemaFinanceiro, SistemaFinanceiroRepository>();
builder.Services.AddScoped<IUsuarioSistemaFinanceiro, UsuarioSistemFinanceiroRepository>();

builder.Services.AddScoped<IUnitofWork, UnitOfWork>();

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