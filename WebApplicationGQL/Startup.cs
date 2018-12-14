using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAPIGQL.GraphQL.NewsQST;
using WebAPIGQL.Model;
using WebAPIGQL.Services;

namespace WebAPIGQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<INewsService,NewsService>();
            services.AddSingleton<News>();
            services.AddSingleton<NewsType>();
            services.AddSingleton<NewsQuery>();
            
            var sp = services.BuildServiceProvider();


            services.AddSingleton<ISchema, NewsSchema>();
            services.AddSingleton<IDependencyResolver>(s=>
                new FuncDependencyResolver(type => sp.GetRequiredService(type)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseMvc();
            app.UseGraphiQl();
            
        }
    }
}
