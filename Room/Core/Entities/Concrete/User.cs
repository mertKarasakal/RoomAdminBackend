using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int StatusId { get; set; }
        //public int LanguageId { get; set; }
        //public int UserPreferencesId { get; set; }
        //public int ProfilePhotoId { get; set; }
        //public int SubscriptionPlanId { get; set; }
        public string Email { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
