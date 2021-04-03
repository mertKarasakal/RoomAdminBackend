using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        //default duration 60 dk olsun 
        //değer girilirse de girilen değer olur
        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            var arguments = invocation.Arguments.ToList();

            //metodun parametrelerine bakacak bütün parametreleri biraraya getirecek örneğin:
            //ProductManager.GetByCategory(1,abcvyz)
            //bu sayede farklı parametrelere göre farklı keyler olacak
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";

            //bu key önceden eklenmiş ise cache'te ise
            if (_cacheManager.IsAdd(key))
            {
                //cache'den al
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }

            //metodu çalıştır
            invocation.Proceed();

            //son çalışan değeri al cache'e ekle
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }
    }
}
