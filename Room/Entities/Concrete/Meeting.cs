using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Meeting : IEntity
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public int HostId { get; set; }
        public int MeetingSettingsId { get; set; }
        public string Title { get; set; }
        public string InviteLink { get; set; }
        public bool IsLocked { get; set; }
        public string Passcode { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public bool IsContinue { get; set; }
        public bool IsStarted { get; set; }
        public bool IsActive { get; set; }
    }
}
