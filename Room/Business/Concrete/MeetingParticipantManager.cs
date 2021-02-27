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
    public class MeetingParticipantManager : IMeetingParticipantService
    {
        public IDataResult<MeetingParticipant> GetById(int meetingParticipantId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MeetingParticipant>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(MeetingParticipant meetingParticipant)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MeetingParticipant meetingParticipant)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MeetingParticipant meetingParticipant)
        {
            throw new NotImplementedException();
        }
    }
}
