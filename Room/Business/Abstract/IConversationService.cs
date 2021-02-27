using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IConversationService
    {
        IDataResult<Conversation> GetById(int conversationId);
        IDataResult<List<Conversation>> GetList();
        IResult Add(Conversation conversation);
        IResult Delete(Conversation conversation);
        IResult Update(Conversation conversation);
    }
}
