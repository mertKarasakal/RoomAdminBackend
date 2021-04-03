using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Business;
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

        [PerformanceAspect(5)]
        [LogAspect(typeof(JsonFileLogger))]
        [CacheAspect(duration:10)]
        [SecuredOperation("Status.List,Admin")]
        public IDataResult<List<Status>> GetList()
        {
            return new SuccessDataResult<List<Status>>(_statusDal.GetList().ToList());
        }

        //Get, GetLİst, GetListByCategory
        [CacheRemoveAspect("IStatusService.Get")]
        //[CacheRemoveAspect("ICategoryService.Get")]
        [ValidationAspect(typeof(StatusValidator), Priority = 1)]
        public IResult Add(Status status)
        {
            IResult result = BusinessRules.Run(
                CheckIfStatusTitleExists(status.Title));

            if (result != null)
            {
                return result;
            }

            _statusDal.Add(status);
            return new SuccessResult(Messages.StatusAdded);
        }

        public IResult Delete(Status status)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Status status)
        {
            throw new NotImplementedException();
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Status status)
        {
            //ilk işlem başarılı olsun ikincisi başarısız olsun (test için)
            _statusDal.Update(status);
            _statusDal.Add(status);

            return new SuccessResult(Messages.StatusUpdated);
        }

        private IResult CheckIfStatusTitleExists(string title)
        {
            if (_statusDal.Get(s=>s.Title == title) != null)
            {
                return new ErrorResult(Messages.StatusNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
