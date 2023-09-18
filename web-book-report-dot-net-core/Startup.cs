using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace web_book_report_dot_net_core
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //ciclos de vida de servicos:

            //mecanismo de injecao de dependencia transitoria/temporario, cria uma instancia nova pra cada requisicao/chamada
            //services.AddTransient<ICatalogo, Catalogo>();
            //services.AddTransient<IRelatorio, Relatorio>();

            //mecanismo de injecao de dependencia com escopo nao transitoria/temporario, cria uma instancia apenas pra cada requisicao
            //services.AddScoped<ICatalogo, Catalogo>();
            //services.AddScoped<IRelatorio, Relatorio>();

            //cria uma instancia unica enquanto a aplicacao estiver em execucao, sao o mesmo para todas as requisicoes
            var catalogo = new Catalogo();
            services.AddSingleton<ICatalogo>(catalogo);
            services.AddSingleton<IRelatorio>(new Relatorio(catalogo));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //com serviceProvider nao eh necessario criar instancia pois eh feito pelo asp.net
            ICatalogo catalogo = serviceProvider.GetService<ICatalogo>();
            IRelatorio relatorio = serviceProvider.GetService<IRelatorio>();

            app.Run(async (context) =>
            {
                await relatorio.Imprimir(context);
            });
        }
    }
}
