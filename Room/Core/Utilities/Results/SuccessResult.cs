using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //ıssucces değeri default true yapıldı
        public SuccessResult(string message) : base(true, message)
        {
        }

        //mesajsız
        public SuccessResult() : base(true)
        {
        }
    }
}
