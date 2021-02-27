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
    public class RoleManager : IRoleService
    {
        public IDataResult<Role> GetById(int roleId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Role>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Role role)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Role role)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
