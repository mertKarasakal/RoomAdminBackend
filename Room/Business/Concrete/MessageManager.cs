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
    public class MessageManager : IMessageService
    {
        public IDataResult<Message> GetById(int messageId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Message>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Message message)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Message message)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
