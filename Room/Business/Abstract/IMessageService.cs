using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMessageService
    {
        IDataResult<Message> GetById(int messageId);
        IDataResult<List<Message>> GetList();
        IResult Add(Message message);
        IResult Delete(Message message);
        IResult Update(Message message);
    }
}
