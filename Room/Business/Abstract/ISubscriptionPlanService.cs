using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISubscriptionPlanService
    {
        IDataResult<SubscriptionPlan> GetById(int subscriptionPlanId);
        IDataResult<List<SubscriptionPlan>> GetList();
        IResult Add(SubscriptionPlan subscriptionPlan);
        IResult Delete(SubscriptionPlan subscriptionPlan);
        IResult Update(SubscriptionPlan subscriptionPlan);
    }
}
