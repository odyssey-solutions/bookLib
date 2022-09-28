using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Entity.Enum
{
   
    public enum EventTypeEnum
    {
        AgentAssignmentChanged,
        AttachmentLinkedtoComment,
        AttachmentRedactedfromComment,
        BrandChanged,
        CommentCreated,
        CommentRedacted,
        CustomFieldChanged,
        DescriptionChanged,
        EmailCCsChanged,
        ExternalIDChanged, //startfromhere
        FollowersChanged,
        FormChanged,
        GroupAssignmentChanged,
        OrganizationChanged,
        PriorityChanged,
        ProblemLinkChanged,
        RequesterChanged,
        StatusChanged,
        CommentMadePrivate
    }
    public enum UserEventTypeEnum
    {
        description,
        ActiveStatusChanged,
        AliasChanged,
        CustomFieldChanged,
        CustomRoleChanged,
        DefaultGroupChanged,
        DetailsChanged,
        ExternalIDChanged,
        GroupAdded,
        GroupRemoved,
        IdentityChanged,
        IdentityCreated,
        IdentityDeleted,
        LastLoginChanged,
        LocaleChanged,
        NameChanged,
        NotesChanged,
        OnlyPrivateCommentsChanged,
        OrganizationAdded,
        OrganizationRemoved,
        PhotoChanged,
        RoleChanged,
        TagsChanged,
        TimeZoneChanged,
        UserCreated,
        UserMerged
    }
    public enum OrganizationEventTypeEnum
    {
        CustomFieldChanged,
        ExternalIDChanged,
        OrganizationCreated,
        TagsChanged
    }


}
