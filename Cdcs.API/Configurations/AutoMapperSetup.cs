#region

using System;
using AutoMapper;
using CDCS.Model.Profiles;
using Microsoft.Extensions.DependencyInjection;

#endregion

namespace Cdcs.API.Configurations {

    public static class AutoMapperSetup {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            // Registering Mappings automatically only works if the 
            // Automapper Profile classes are in ASP.NET project
            AutoMapperConfig.RegisterMappings();
        }
    }

}