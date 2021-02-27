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
    public class PhotoManager : IPhotoService
    {
        public IDataResult<Photo> GetById(int photoId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Photo>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Photo photo)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Photo photo)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Photo photo)
        {
            throw new NotImplementedException();
        }
    }
}
