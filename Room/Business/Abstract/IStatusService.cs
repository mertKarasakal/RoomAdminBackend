using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStatusService
    {
        IDataResult<Status> GetById(int statusId);
        IDataResult<List<Status>> GetList();
        IResult Add(Status status);
        IResult Delete(Status status);
        IResult Update(Status status);

        IResult TransactionalOperation(Status status);

    }
}
