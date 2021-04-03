using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors.Autofac;

namespace Core.Aspects.Autofac.Transaction
{
    public class TransactionScopeAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    //metodu çalıştırmayı dene
                    invocation.Proceed();
                    
                    //başarılı ise işlemi kabul et ve çalıştır
                    transactionScope.Complete();
                }
                catch (System.Exception e)
                {
                    //yapılan işlemleri geri al
                    transactionScope.Dispose();
                    throw; //hata fırlat
                }
            }
        }
    }
}
