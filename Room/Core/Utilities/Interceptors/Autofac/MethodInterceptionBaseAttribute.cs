using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors.Autofac
{
    //class'larda ve metotlarda kullanılabilir
    //birden fazla kullanılabilir ve inherit eden alt sınıflarda da kullanılabilir
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {
           
        }
    }
}
