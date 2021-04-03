using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Core.Aspects.Autofac.Exception;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace Core.Utilities.Interceptors.Autofac
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
           
            //type: aspect e eklenen sınıf (productmanager gibi)
            var classAttributes = type
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();

            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);

            classAttributes.AddRange(methodAttributes);

            //her metot için çalıştırılır
            ///eğer veritabanına bağlanma hatası alırsa oraya kaydedemez
            /// ikisi de çalıştırılırsa performans sıkıntısı yaşanabilir
            //classAttributes.Add(new ExceptionLogAspect(typeof(DatabaseLogger)));  
            classAttributes.Add(new ExceptionLogAspect(typeof(JsonFileLogger)));

            //önceliğe göre sıralar
            return classAttributes.OrderBy(x => x.Priority).ToArray();

        }
    }
}
