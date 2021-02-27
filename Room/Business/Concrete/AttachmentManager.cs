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
    public class AttachmentManager : IAttachmentService
    {
        public IDataResult<Attachment> GetById(int attachmentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Attachment>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Attachment attachment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Attachment attachment)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Attachment attachment)
        {
            throw new NotImplementedException();
        }
    }
}
