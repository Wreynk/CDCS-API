#region

using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using Cdcs.API.Configurations;
using Cdcs.API.Helpers;
using CDCS.Data;
using CDCS.Model.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

#endregion

namespace Cdcs.API {

    public class Startup {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DbConnectionString");
            services.AddDbContext<CdcsContext>(options => options.UseSqlServer(connectionString));

            services.AddSwaggerGen(options => {
                                       options.SwaggerDoc("v1",
                                                          new OpenApiInfo {
                                                              Version     = "v1",
                                                              Title       = "CDCS API",
                                                              Description = "API to retrieve date from CDCS",
                                                              Contact = new OpenApiContact {
                                                                  Name = "PMV", Email = "p.mv@pfcsm-opgg.be", Url = new Uri("http://www.pfcsm-opgg.be")
                                                              }
                                                          });

                                       string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                                       string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                                       options.IncludeXmlComments(xmlPath);
                                       options.DocumentFilter<LowercaseDocumentFilter>();
                                   });

            // var mappingConfig = new MapperConfiguration(x => { x.AddProfile(new CdcsDtoProfiles()); });
            // var mapper        = mappingConfig.CreateMapper();
            // services.AddSingleton(mapper);

            services.AddAutoMapperSetup();

            services.AddRouting(opt => { opt.LowercaseUrls = true; });

            services.AddMvc()
                    .AddMvcOptions(o => o.OutputFormatters.Add(
                                       new XmlSerializerOutputFormatter()
                                   )
                    )

                    // .AddXmlSerializerFormatters()
                    // .AddJsonOptions(o =>
                    // {
                    //     if (o.SerializerSettings.ContractResolver == null) return;
                    //
                    //     var cr = o.SerializerSettings.ContractResolver as DefaultContractResolver;
                    //     cr.NamingStrategy = null;
                    //
                    // })
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseSwagger();

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseHttpsRedirection();
                app.UseExceptionHandler();
                app.UseHsts();
            }

            // app.UseStatusCodePages();

            app.UseSwaggerUI(options => {
                                 options.SwaggerEndpoint("/swagger/v1/swagger.json", "CDCS API V1");

                                 // options.RoutePrefix = "docs";
                             });

            // app.UseSwaggerUI();
            app.UseMvc();
        }
    }

}