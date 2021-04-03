using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {

        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        void IUserService.Add(User user)
        {
            _userDal.Add(user);
        }


        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }



        public IDataResult<User> GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetList()
        {
            throw new NotImplementedException();
        }

       

        

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
