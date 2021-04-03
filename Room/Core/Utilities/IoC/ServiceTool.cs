using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    /// <summary>
    /// Uygulamamızın service collection nesnesine
    /// (onun da arkasında olan service provider ı) na erişecek
    /// sistemin servislerini merkezi bir noktadan (bu tool vasıtasıyla)
    /// kontrol ediyor olucaz
    /// ayrıca ioc resolver görevi de görecek bir altyapı olacak
    /// </summary>
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
