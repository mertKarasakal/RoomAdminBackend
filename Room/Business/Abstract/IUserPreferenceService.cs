using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserPreferenceService
    {
        IDataResult<UserPreference> GetById(int userPreferenceId);
        IDataResult<List<UserPreference>> GetList();
        IResult Add(UserPreference userPreference);
        IResult Delete(UserPreference userPreference);
        IResult Update(UserPreference userPreference);
    }
}
