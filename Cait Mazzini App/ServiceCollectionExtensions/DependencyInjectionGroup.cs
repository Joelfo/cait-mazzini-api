﻿using Cait_Mazzini_App.Database.Repositories.EFCore;
using Cait_Mazzini_App.Database.Repositories.Interfaces;

namespace Cait_Mazzini_App.ServiceCollectionExtensions
{
    public static class DependencyInjectionGroup
    {
        public static IServiceCollection AddDependencyInjectionGroup(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<,>), typeof(EFCoreGenericRepository<,>));
            return services;
        }
    }
}
