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
    public class UserRoleManager : IUserRoleService
    {
        public IDataResult<UserRole> GetById(int userRoleId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserRole>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(UserRole userRole)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UserRole userRole)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}
