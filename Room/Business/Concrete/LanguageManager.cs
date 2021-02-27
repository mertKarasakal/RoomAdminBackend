using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class LanguageManager : ILanguageService
    {
        public IDataResult<Language> GetById(int languageId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Language>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Language language)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Language language)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Language language)
        {
            throw new NotImplementedException();
        }
    }
}
