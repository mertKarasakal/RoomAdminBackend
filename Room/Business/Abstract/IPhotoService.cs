using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPhotoService
    {
        IDataResult<Photo> GetById(int photoId);
        IDataResult<List<Photo>> GetList();
        IResult Add(Photo photo);
        IResult Delete(Photo photo);
        IResult Update(Photo photo);
    }
}
