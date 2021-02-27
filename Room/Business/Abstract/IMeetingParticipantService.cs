using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMeetingParticipantService
    {
        IDataResult<MeetingParticipant> GetById(int meetingParticipantId);
        IDataResult<List<MeetingParticipant>> GetList();
        IResult Add(MeetingParticipant meetingParticipant);
        IResult Delete(MeetingParticipant meetingParticipant);
        IResult Update(MeetingParticipant meetingParticipant);
    }
}
