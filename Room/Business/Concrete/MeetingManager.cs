﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MeetingManager : IMeetingService
    {
        public IDataResult<Meeting> GetById(int meetingId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Meeting>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Meeting meeting)
        {
            throw new NotImplementedException();
        }
    }
}
