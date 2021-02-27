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
    public class MessageParticipantManager : IMessageParticipantService
    {
        public IDataResult<MessageParticipant> GetById(int messageParticipantId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MessageParticipant>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(MessageParticipant messageParticipant)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MessageParticipant messageParticipant)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MessageParticipant messageParticipant)
        {
            throw new NotImplementedException();
        }
    }
}
