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
    public class FileManager : IFileService
    {
        public IDataResult<File> GetById(int fileId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<File>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(File file)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(File file)
        {
            throw new NotImplementedException();
        }

        public IResult Update(File file)
        {
            throw new NotImplementedException();
        }
    }
}
