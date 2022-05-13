using Castle.DynamicProxy;
using System;

namespace Autofac_AOP_Demo.Interceptors
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"Executing - {invocation.MethodInvocationTarget.DeclaringType?.FullName}." +
                              $"{invocation.Method.Name}");

            invocation.Proceed();

            Console.WriteLine("Finished Logging");
        }
    }
}