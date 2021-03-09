using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {//polimorfizm/ this burada parametre demek değil neyi genişletmek istiyorsak onun önüne gelir  
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,ICoreModule[] modules)
        {//bizim core katmanıda dahil olmak üzere ekleyeceğimiz bütün injeksınları bir arada toplayabileceğimiz bir yapıdir 
            foreach (var module in modules)
            {//birden fazla mudule ekleyebilriz bu meteotla ilerde başka modele geçtiğimizde rahatlıkla ekleriz
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
