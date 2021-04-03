using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core.Extensions
{
    public class ErrorDetails
    {
        /// <summary>
        /// kullanıcıya gönderilecek olan mesaj
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// kullanıcıya gönderilecek olan hata kodu
        /// </summary>
        public int StatusCode { get; set; }

        public override string ToString()
        {
            //bu nesneyi olduğu gibi yazdırmak için
            return JsonConvert.SerializeObject(this);
        }
    }
}
