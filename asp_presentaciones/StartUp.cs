using lib_comunicaciones.Implementaciones;
using lib_comunicaciones.Interfaces;
using lib_presentaciones.Implementaciones;
using lib_presentaciones.Interfaces;

namespace asp_presentacion
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration? Configuration { set; get; }

        public void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {
            // Comunicaciones
            services.AddScoped<IClientesComunicacion, ClientesComunicacion>();
            services.AddScoped<IDetallesComunicacion, DetallesComunicacion>();
            services.AddScoped<IFacturasComunicacion, FacturasComunicacion>();
            services.AddScoped<IMensajerosComunicacion, MensajerosComunicacion>();
            services.AddScoped<IMetodos_de_pagoComunicacion, Metodos_de_PagoComunicacion>();
            services.AddScoped<IPedidosComunicacion, PedidosComunicacion>();
            services.AddScoped<IProductosComunicacion, ProductosComunicacion>();
            services.AddScoped<IRemitentesComunicacion, RemitentesComunicacion>();
            // Presentaciones
            services.AddScoped<IClientesPresentacion, ClientesPresentacion>();
            services.AddScoped<IDetallesPresentacion, DetallesPresentacion>();
            services.AddScoped<IFacturasPresentacion, FacturasPresentacion>();
            services.AddScoped<IMensajerosPresentacion, MensajerosPresentacion>();
            services.AddScoped<IProductosPresentacion, ProductosPresentacion>();
            services.AddScoped<IMetodos_de_pagoPresentacion, Metodos_de_pagoPresentacion>();
            services.AddScoped<IPedidosPresentacion, PedidosPresentacion>();
            services.AddScoped<IRemitentesPresentacion, RemitentesPresentacion>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.UseSession();
            app.Run();
        }
    }
}