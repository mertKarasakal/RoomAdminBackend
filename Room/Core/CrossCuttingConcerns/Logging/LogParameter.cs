using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogParameter
    {
        /// <summary>
        /// örneğin product nesnesi var isim olarak da
        /// instance a product dendi name bunu tutar
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// name property'sinin değerini tutar
        /// örneğin bir products nesnesi id'si 1
        /// product name'i elma
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// örneğin nesne product ise bu onu tutar
        /// </summary>
        public string Type { get; set; }
    }
}
