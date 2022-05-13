using Autofac_AOP_Demo.Services.LogService;
using System;

namespace Autofac_AOP_Demo.Services
{
    public class BeforeSomethingExecute : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("BeforeSomethingExecute Finished");

            var logService = new Logging();
            logService.Execute();
        }
    }
}