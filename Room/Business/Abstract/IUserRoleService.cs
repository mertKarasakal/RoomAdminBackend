using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserRoleService
    {
        IDataResult<UserRole> GetById(int userRoleId);
        IDataResult<List<UserRole>> GetList();
        IResult Add(UserRole userRole);
        IResult Delete(UserRole userRole);
        IResult Update(UserRole userRole);
    }
}
