using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMeetingService
    {
        IDataResult<Meeting> GetById(int meetingId);
        IDataResult<List<Meeting>> GetList();
        IResult Add(Meeting meeting);
        IResult Delete(Meeting meeting);
        IResult Update(Meeting meeting);
    }
}
