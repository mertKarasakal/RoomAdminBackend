using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        public IDataResult<OperationClaim> GetById(int operationClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationClaim>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Update(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }
    }
}
