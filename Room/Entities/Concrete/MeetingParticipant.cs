using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class MeetingParticipant : IEntity
    {
        public int Id { get; set; }
        public int MeetingId { get; set; }
        public int UserId { get; set; }
        public bool IsVideoOn { get; set; }
        public bool IsVoiceOn { get; set; }
        public bool IsScreenShared { get; set; }
    }
}
