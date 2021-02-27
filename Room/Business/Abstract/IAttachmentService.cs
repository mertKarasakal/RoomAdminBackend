using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAttachmentService
    {
        IDataResult<Attachment> GetById(int attachmentId);
        IDataResult<List<Attachment>> GetList();
        IResult Add(Attachment attachment);
        IResult Delete(Attachment attachment);
        IResult Update(Attachment attachment);
    }
}
