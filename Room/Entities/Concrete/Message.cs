using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public int AttachmentId { get; set; }
    }
}
