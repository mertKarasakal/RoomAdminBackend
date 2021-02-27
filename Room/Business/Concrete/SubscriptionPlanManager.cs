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
    public class SubscriptionPlanManager : ISubscriptionPlanService
    {
        public IDataResult<SubscriptionPlan> GetById(int subscriptionPlanId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SubscriptionPlan>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(SubscriptionPlan subscriptionPlan)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SubscriptionPlan subscriptionPlan)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SubscriptionPlan subscriptionPlan)
        {
            throw new NotImplementedException();
        }
    }
}
