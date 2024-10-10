using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proyecto1Avanzada.Repositories;
using Proyecto1Avanzada.Repositories.Configuration;
using Proyecto1Avanzada.Services;
using System.Data.Common;

namespace Proyecto1Avanzada
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("AppSetting.json").Build();

            

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IConnection,DatabaseConnection>();
            services.AddScoped<IProductsRepository,ProductsRepository>();
            services.AddScoped<ICategoriesRepository,CategoriesRepository>();
            services.AddScoped <ISuppliersRepository,SuppliersRepository>();
            services.AddTransient<ISuppliersServices, SuppliersServices>();
            services.AddTransient<IProductsServices,ProductsServices>();
            services.AddTransient<ICategoriesServices,CategoriesServices>();


            services.AddTransient<Form1>();
            services.AddTransient<Categories>();
            services.AddTransient<Crear_Categorias>();
            services.AddTransient<Crear_Productos>();
            services.AddTransient<Crear_Suplidor>();
            services.AddTransient<Suppliers>();



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var provider = services.BuildServiceProvider();
           
            var ProductsForm = provider.GetService<Form1>();

           
            Application.Run(ProductsForm);
        }
    }
}   