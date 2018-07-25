// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Rawfer.Server
{
    using System.Linq;
    using System.Net.Mime;

    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Blazor.Server;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.ResponseCompression;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using Newtonsoft.Json.Serialization;

    using Rawfer.Shared;
    using Rawfer.Shared.Repositories;
    using Rawfer.Shared.Services;

    using Tiddly.Sql.DataAccess;

    // ReSharper disable once UnusedMember.Global
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            // Configuration from appsettings.json has already been loaded by
            // CreateDefaultBuilder on WebHost in Program.cs. Use DI to load
            // the configuration into the Configuration property.
            this.Configuration = config;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });

            services.AddResponseCompression(options =>
            {
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm,
                });
            });

            services.AddIdentityCore<UserModelApi>(options =>
            {
                options.User.RequireUniqueEmail = false;
            })
            .AddUserManager<UserModelManager>()
            .AddSignInManager<UserSignInManager>()
            .AddUserStore<UserStore>()
            .AddDefaultTokenProviders();

            services.AddScoped<IAnimalService, AnimalService>();
            services.AddScoped<IAnimalRepository, AnimalRepository>();
            services.AddScoped<IFoodService, FoodService>();
            services.AddScoped<IFoodItemRepository, FoodItemRepository>();
            services.AddSingleton(new SqlDataAccess(this.Configuration["DbConnection"]));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/signin";
                    options.LogoutPath = "/signout";
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller}/{action}/{id?}");
            });

            app.UseBlazor<Client.Program>();
        }
    }
}
