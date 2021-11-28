using DevIO.Data.Context;
using DevIO.App.Extensions;
using DevIO.Data.Repository;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Business.Intefaces;

namespace DevIO.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddRazorPages();

            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorServices, FornecedorServices>();
            services.AddScoped<IProdutoServices, ProdutoServices>();

            return services;
        }
    }
}
