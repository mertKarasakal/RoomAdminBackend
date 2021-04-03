using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var result in logics)
            {
                //eğer işlem sonucu başarılı değilse
                if (!result.Success)
                {
                    return result;
                }
            }

            //tüm iş kurallarını geçti ise
            return null;
        }
    }
}
