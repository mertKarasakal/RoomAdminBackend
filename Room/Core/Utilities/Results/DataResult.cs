using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //sadece data gönderilebilir veya data, success ve message gönderilebilir
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        //mesajsız data ve bool gönderilebilir
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
