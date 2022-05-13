using Autofac;
using Autofac.Extras.DynamicProxy;
using Autofac_AOP_Demo.Interceptors;
using Autofac_AOP_Demo.Services;
using System;

namespace Autofac_AOP_Demo
{
    class Program
    {
        static void Main()
        {
            var beforeSomethingExecute = new BeforeSomethingExecute();
            beforeSomethingExecute.Execute();

            Console.WriteLine("------------------------");

            var container = BuildContainer();
            using var scope = container.BeginLifetimeScope();
            var afterSomethingExecute = scope.Resolve<AfterSomethingExecute>();
            afterSomethingExecute.Execute();

            Console.Read();
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<LoggingInterceptor>();

            builder.RegisterType<AfterSomethingExecute>()
                .SingleInstance()
                .EnableClassInterceptors()
                .InterceptedBy(typeof(LoggingInterceptor));

            return builder.Build();
        }
    }
}
