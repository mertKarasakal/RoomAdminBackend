using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class RoomContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                @"Server = localhost; Port=5432; Database=Room; User Id=postgres; Password=turkuaz; Integrated Security = true; Pooling = true");
        }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingParticipant> MeetingParticipants { get; set; }
        public DbSet<MeetingSetting> MeetingSettings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageParticipant> MessageParticipants { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserPreference> UserPreferences { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


    }
}
