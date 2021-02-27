using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ILanguageService
    {
        IDataResult<Language> GetById(int languageId);
        IDataResult<List<Language>> GetList();
        IResult Add(Language language);
        IResult Delete(Language language);
        IResult Update(Language language);
    }
}
