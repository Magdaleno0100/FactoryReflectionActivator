using Factory.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Factory
{
    public class ControllerFactory
    {
        public T CreateInstance<T>(string name) where T : class
        {
            Type classWithInterface = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ICargaDatos).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract && x.Name.StartsWith(name)).FirstOrDefault();

            if (classWithInterface is not null)
                return Activator.CreateInstance(classWithInterface) as T;

            return null;
        }

        public List<string> GetAllEntities(string name)
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ICargaDatos).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract && x.Name.StartsWith(name))
                .Select(x => x.Name).ToList();
        }

    }
}
