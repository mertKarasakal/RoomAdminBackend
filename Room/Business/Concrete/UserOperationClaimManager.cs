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
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        public IDataResult<UserOperationClaim> GetById(int userOperationClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserOperationClaim>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(UserOperationClaim userOperationClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UserOperationClaim userOperationClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserOperationClaim userOperationClaim)
        {
            throw new NotImplementedException();
        }
    }
}
