using Factory.Factory;
using Factory.Factory.Interfaces;
using System;

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
            Console.ReadKey();
        }
    }
}
