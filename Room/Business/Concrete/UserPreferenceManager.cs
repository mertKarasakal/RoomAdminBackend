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
    public class UserPreferenceManager : IUserPreferenceService
    {
        public IDataResult<UserPreference> GetById(int userPreferenceId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserPreference>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(UserPreference userPreference)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UserPreference userPreference)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserPreference userPreference)
        {
            throw new NotImplementedException();
        }
    }
}
