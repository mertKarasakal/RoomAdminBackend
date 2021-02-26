using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class UserPreference : IEntity
    {
        public int Id { get; set; }
        public string UserMeetingCode { get; set; }
    }
}
