using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        IDataResult<OperationClaim> GetById(int operationClaimId);
        IDataResult<List<OperationClaim>> GetList();
        IResult Add(OperationClaim operationClaim);
        IResult Delete(OperationClaim operationClaim);
        IResult Update(OperationClaim operationClaim);
    }
}
