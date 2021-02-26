using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StatusManager : IStatusService
    {
        private IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public IDataResult<Status> GetById(int statusId)
        {
            return new SuccessDataResult<Status>(_statusDal.Get(p=>p.Id == statusId));
        }

        public IDataResult<List<Status>> GetList()
        {
            return new SuccessDataResult<List<Status>>(_statusDal.GetList().ToList());
        }

        public IResult Add(Status status)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Status status)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
