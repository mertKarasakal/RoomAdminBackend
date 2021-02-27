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
    public class ContactManager : IContactService
    {
        public IDataResult<Contact> GetById(int contactId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
