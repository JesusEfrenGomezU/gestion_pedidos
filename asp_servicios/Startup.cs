using asp_servicios.Controllers;
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace asp_servicios
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
            services.Configure<KestrelServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.Configure<IISServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();
            services.AddScoped<Conexion, Conexion>();
            // Repositorios
            services.AddScoped<IClientesRepositorio, ClientesRepositorio>();
            services.AddScoped<IAuditoriasRepositorio,AuditoriasRepositorio>();
            services.AddScoped<IDetallesRepositorio, DetallesRepositorio>();
            services.AddScoped<IFacturasRepositorio, FacturasRepositorio>();
            services.AddScoped<IMensajerosRepositorio, MensajerosRepositorio>();
            services.AddScoped<IMetodos_de_pagoRepositorio, Metodos_de_pagoRepositorio>();
            services.AddScoped<IPedidosRepositorio, PedidosRepositorio>();
            services.AddScoped<IProductosRepositorio, ProductosRepositorio>();
            services.AddScoped<IRemitentesRepositorio, RemitentesRepositorio>();
            services.AddScoped<IRolesRepositorio,RolesRepositorio>();
            services.AddScoped<IUsuariosRepositorio, UsuariosRepositorio>();
            // Aplicaciones
            services.AddScoped<IClientesAplicacion, ClientesAplicacion>();
            services.AddScoped<IDetallesAplicacion, DetallesAplicacion>();
            services.AddScoped<IFacturasAplicacion, FacturasAplicacion>();
            services.AddScoped<IMensajerosAplicacion, MensajerosAplicacion>();
            services.AddScoped<IMetodos_de_pagoAplicacion, Metodos_de_pagoAplicacion>();
            services.AddScoped<IPedidosAplicacion, PedidosAplicacion>();
            services.AddScoped<IProductosAplicacion, ProductosAplicacion>();
            services.AddScoped<IRemitentesAplicacion, RemitentesAplicacion>();
            services.AddScoped<IRolesAplicacion, RolesAplicacion>();
            services.AddScoped<IUsuariosAplicacion, UsuariosAplicacion>();
            // Controladores
            services.AddScoped<TokenController, TokenController>();
            Conexion Conexion = new Conexion();
            IClientesRepositorio IClientesRepositorio = new ClientesRepositorio(Conexion);

            services.AddCors(o => o.AddDefaultPolicy(b => b.AllowAnyOrigin()));
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
            app.UseRouting();
            app.UseCors();
        }
    }
}
