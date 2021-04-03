using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public string SpecificName { get; set; }
        public bool IsStarred { get; set; }
        public bool IsBlocked { get; set; }
    }
}
