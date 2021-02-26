using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Attachment : IEntity
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string Name { get; set; }
    }
}
