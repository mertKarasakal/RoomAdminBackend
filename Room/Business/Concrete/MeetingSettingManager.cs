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
    public class MeetingSettingManager : IMeetingSettingService
    {
        public IDataResult<MeetingSetting> GetById(int meetingSettingId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MeetingSetting>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(MeetingSetting meetingSetting)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MeetingSetting meetingSetting)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MeetingSetting meetingSetting)
        {
            throw new NotImplementedException();
        }
    }
}
