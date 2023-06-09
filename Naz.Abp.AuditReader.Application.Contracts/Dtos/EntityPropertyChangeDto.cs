using Volo.Abp.Application.Dtos;

namespace Naz.Abp.AuditReader.Dtos
{
    public class EntityPropertyChangeDto : EntityDto<Guid>
    {
        public virtual Guid? TenantId { get; protected set; }

        public virtual Guid EntityChangeId { get; protected set; }

        public virtual string NewValue { get; protected set; }

        public virtual string OriginalValue { get; protected set; }

        public virtual string PropertyName { get; protected set; }

        public virtual string PropertyTypeFullName { get; protected set; }
    }
}
