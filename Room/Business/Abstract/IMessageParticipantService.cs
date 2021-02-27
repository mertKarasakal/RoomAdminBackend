using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMessageParticipantService
    {
        IDataResult<MessageParticipant> GetById(int messageParticipantId);
        IDataResult<List<MessageParticipant>> GetList();
        IResult Add(MessageParticipant messageParticipant);
        IResult Delete(MessageParticipant messageParticipant);
        IResult Update(MessageParticipant messageParticipant);
    }
}
