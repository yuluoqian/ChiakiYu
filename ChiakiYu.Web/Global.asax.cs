﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using ChiakiYu.Core.Dependency;
using ChiakiYu.Core.Domain.Repositories;
using ChiakiYu.EntityFramework;
using ChiakiYu.EntityFramework.Migrations;
using ChiakiYu.Service.Settings;

namespace ChiakiYu.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperInitialize.Initialize();
            AutofacRegister();
            DatabaseInitialize();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        ///     Autofac注册
        /// </summary>
        private static void AutofacRegister()
        {
            var builder = new ContainerBuilder();
            builder.RegisterGeneric(typeof (Repository<,>)).As(typeof (IRepository<,>));
            builder.RegisterGeneric(typeof (SettingService<>)).As(typeof (ISettingService<>));
            var baseType = typeof (IDependency);
            var path = AppDomain.CurrentDomain.RelativeSearchPath;
            var assemblies = Directory.GetFiles(path, "*.dll").Select(m => Assembly.LoadFrom(m)).ToArray();
            builder.RegisterAssemblyTypes(assemblies)
                .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
                .AsSelf() //自身服务，用于没有接口的类
                .AsImplementedInterfaces() //接口服务
                .PropertiesAutowired() //属性注入
                .InstancePerLifetimeScope(); //保证生命周期基于请求

            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterFilterProvider();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        ///     设置数据库初始化
        /// </summary>
        private static void DatabaseInitialize()
        {
            CreateDatabaseIfNotExistsWithSeed.SeedActions.Add(new SeedDataInitialize());
            //var file = HttpContext.Current.Server.MapPath("/bin/ChiakiYu.Mapping.dll");
            //var assembly = Assembly.LoadFrom(file);
            //DatabaseInitializer.AddMapperAssembly(assembly);
            DatabaseInitializer.Initialize();
        }
    }
}