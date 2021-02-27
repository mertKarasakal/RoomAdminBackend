using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //eğer ctor da IStatusService çağırılırsa StatusManager'ı verir
            builder.RegisterType<AttachmentManager>().As<IAttachmentService>();
            builder.RegisterType<EfAttachmentDal>().As<IAttachmentDal>();

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<ConversationManager>().As<IConversationService>();
            builder.RegisterType<EfConversationDal>().As<IConversationDal>();

            builder.RegisterType<FileManager>().As<IFileService>();
            builder.RegisterType<EfFileDal>().As<IFileDal>();

            builder.RegisterType<LanguageManager>().As<ILanguageService>();
            builder.RegisterType<EfLanguageDal>().As<ILanguageDal>();

            builder.RegisterType<MeetingManager>().As<IMeetingService>();
            builder.RegisterType<EfMeetingDal>().As<IMeetingDal>();

            builder.RegisterType<MeetingParticipantManager>().As<IMeetingParticipantService>();
            builder.RegisterType<EfMeetingParticipantDal>().As<IMeetingParticipantDal>();

            builder.RegisterType<MeetingSettingManager>().As<IMeetingSettingService>();
            builder.RegisterType<EfMeetingSettingDal>().As<IMeetingSettingDal>();

            builder.RegisterType<MessageManager>().As<IMessageService>();
            builder.RegisterType<EfMessageDal>().As<IMessageDal>();

            builder.RegisterType<MessageParticipantManager>().As<IMessageParticipantService>();
            builder.RegisterType<EfMessageParticipantDal>().As<IMessageParticipantDal>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<PhotoManager>().As<IPhotoService>();
            builder.RegisterType<EfPhotoDal>().As<IPhotoDal>();

            builder.RegisterType<RoleManager>().As<IRoleService>();
            builder.RegisterType<EfRoleDal>().As<IRoleDal>();

            builder.RegisterType<StatusManager>().As<IStatusService>();
            builder.RegisterType<EfStatusDal>().As<IStatusDal>();

            builder.RegisterType<SubscriptionPlanManager>().As<ISubscriptionPlanService>();
            builder.RegisterType<EfSubscriptionPlanDal>().As<ISubscriptionPlanDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<UserPreferenceManager>().As<IUserPreferenceService>();
            builder.RegisterType<EfUserPreferenceDal>().As<IUserPreferenceDal>();

            builder.RegisterType<UserRoleManager>().As<IUserRoleService>();
            builder.RegisterType<EfUserRoleDal>().As<IUserRoleDal>();

        }



    }
}
