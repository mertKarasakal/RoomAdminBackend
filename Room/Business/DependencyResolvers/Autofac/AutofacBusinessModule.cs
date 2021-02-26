using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //eğer ctor da IStatusService çağırılırsa StatusManager'ı verir
            builder.RegisterType<StatusManager>().As<IStatusService>();
            builder.RegisterType<EfStatusDal>().As<IStatusDal>();
        }



    }
}
