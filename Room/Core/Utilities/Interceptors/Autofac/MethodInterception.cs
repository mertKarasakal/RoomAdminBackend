using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors.Autofac
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        /// <summary>
        /// metottan önce çalışır ve invocation metot demektir
        /// </summary>
        /// <param name="invocation"></param>
        protected virtual void OnBefore(IInvocation invocation)
        {

        }

        /// <summary>
        /// metot çalıştıktan sonra devreye girer
        /// </summary>
        /// <param name="invocation"></param>
        protected virtual void OnAfter(IInvocation invocation)
        {

        }

        /// <summary>
        /// metot hata verdiğinde devreye girer
        /// </summary>
        /// <param name="invocation"></param>
        protected virtual void OnException(IInvocation invocation, System.Exception e)
        {

        }

        /// <summary>
        /// metot başarı ile sonlandığında devreye girer
        /// </summary>
        /// <param name="invocation"></param>
        protected virtual void OnSuccess(IInvocation invocation)
        {

        }

        public override void Intercept(IInvocation invocation)
        {
            //başlangıçta işlemin başarılı olduğu varsayılır
            var isSuccess = true; 

            //eğer OnBefore da bişey varsa invocation'ı çalıştır
            OnBefore(invocation);
            try
            {
                //metodu çalıştır
                invocation.Proceed();
            }
            catch (Exception e)
            {
                //hata alındığında bu field'ı false'a çevirir
                isSuccess = false;

                //bu noktada bu metot için OnException çalıştırılır
                OnException(invocation, e);

                //hata fırlat
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    //eğer metot başarılı ise OnSuccess'i çalıştırır
                    OnSuccess(invocation);
                }
            }
            //en nihayetinde OnAfter'ı çalıştırır
            OnAfter(invocation);
        }
    }
}
