using System;

namespace Autofac_AOP_Demo.Services
{
    //[Intercept(typeof(LoggingInterceptor))]
    public class AfterSomethingExecute : IExecute
    {
        public virtual void Execute()
        {
            Console.WriteLine("AfterSomethingExecute Finished");
        }
    }
}