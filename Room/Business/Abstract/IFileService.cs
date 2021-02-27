using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFileService
    {
        IDataResult<File> GetById(int fileId);
        IDataResult<List<File>> GetList();
        IResult Add(File file);
        IResult Delete(File file);
        IResult Update(File file);
    }
}
