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
    public class ConversationManager : IConversationService
    {
        public IDataResult<Conversation> GetById(int conversationId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Conversation>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Conversation conversation)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Conversation conversation)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Conversation conversation)
        {
            throw new NotImplementedException();
        }
    }
}
