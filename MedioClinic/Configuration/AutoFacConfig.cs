﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;

using Common;
using XperienceAdapter.Repositories;
using Microsoft.Extensions.Localization;
using XperienceAdapter.Localization;
using XperienceAdapter.Services;
using Business.Repositories;

namespace MedioClinic.Configuration
{
    public class AutoFacConfig
    {
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(type => type.IsClass && !type.IsAbstract && typeof(IService).IsAssignableFrom(type))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(type => type.GetTypeInfo()
                    .ImplementedInterfaces.Any(
                        @interface => @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IRepository<>)))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(type => type.GetTypeInfo()
                    .ImplementedInterfaces.Any(
                        @interface => @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IPageRepository<,>)))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            builder.RegisterType<XperienceStringLocalizerFactory>().As<IStringLocalizerFactory>()
                 .InstancePerLifetimeScope();
            builder.RegisterType<RepositoryServices>().As<IRepositoryServices>()
                  .InstancePerLifetimeScope();

        }
    }
}
