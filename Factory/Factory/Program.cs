using System;
using System.Reflection;
using Factory.Factory;
using Factory.Factory.Interfaces;


namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICargaDatos _instanceFacebook =  new ControllerFactory().CreateInstance<ICargaDatos>("Facebook");
            ICargaDatos _instanceTwitter = new ControllerFactory().CreateInstance<ICargaDatos>("Twitter");

            Console.WriteLine(_instanceTwitter.GetLastName());
            Console.WriteLine(_instanceFacebook.GetLastName());

            var assemblyDataCodeBase = Assembly.GetEntryAssembly();
            var appDomainData = AppDomain.CurrentDomain.GetAssemblies();


            Console.ReadKey();
        }
    }
}
