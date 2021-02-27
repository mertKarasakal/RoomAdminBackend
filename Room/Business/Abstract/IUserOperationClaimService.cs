using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<UserOperationClaim> GetById(int userOperationClaimId);
        IDataResult<List<UserOperationClaim>> GetList();
        IResult Add(UserOperationClaim userOperationClaim);
        IResult Delete(UserOperationClaim userOperationClaim);
        IResult Update(UserOperationClaim userOperationClaim);
    }
}
