using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using moviesApi.Automapper;
using moviesApi.Core;
using moviesApi.Persistence;
using Microsoft.AspNetCore.Authentication.Certificate;

namespace moviesApi
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
            services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
                    .AddCertificate();

            // AutoMapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(
                    new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddDbContext<MoviesDBContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("MoviesConnection")));
            services.AddScoped<MoviesDBContext>();
            services.AddScoped(typeof(IRepository<>), typeof(MoviesDBRepository<>));

            services.AddRouting(options => { options.LowercaseUrls = true; options.LowercaseQueryStrings = true; });
            services.AddControllers().AddNewtonsoftJson(opt => { opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "moviesApi", Version = "v1" });
            });

            // CORS
            services.AddCors(options =>
            {
                options.AddPolicy(Configuration["Cors:Policy"], builder =>
                    builder.WithOrigins(Configuration["Cors:Origin"])
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "moviesApi v1"));
            }

            // Authentication
            app.UseAuthentication();

            // Add the policies of using cors
            app.UseCors(Configuration["Cors:Policy"]);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
