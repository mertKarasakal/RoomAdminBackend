using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        /// <summary>
        /// log'a konu olan (çalıştırılan) metodun ismi
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// metodun birden fazla parametrelerini tutar
        /// </summary>
        public List<LogParameter> LogParameters { get; set; }
    }
}
