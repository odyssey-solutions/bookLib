using BookLibrary.Entity.Enum;

namespace BookLibrary.Entity;

public class EntityType : BaseEntity
{
    public EntityType() : base(EntityTypeEnum.EntityType)
    {
    }
    public string Label { get; set; } // name of record
    public string EntityClass { get; set; }  // name of class ex. DomainLayer.Models.User
    
    
        
    #region Relationships
    public int? ParentId { get; set; }

    #region Relationship Objects

    public EntityType Parent { get; set; }

    public ICollection<EntityType> EntityTypes { get; set; }
    public ICollection<AttributeData> AttributeDatas { get; set; }
    /*
    public ICollection<TicketAction> TicketActions { get; set; }
    public ICollection<Client> Clients { get; set; }
    public ICollection<Communication> Communications { get; set; }
    public ICollection<Membership> Memberships { get; set; }
    public ICollection<ServiceMatrix> ServiceMatrices { get; set; }
    public ICollection<Scheme> Schemes { get; set; }
    public ICollection<Supplier> Suppliers { get; set; }
    public ICollection<Tag> Tags { get; set; }
    public ICollection<TagMap> TagMaps { get; set; }
    public ICollection<Ticket> Tickets { get; set; }
    public ICollection<User> UserTypes { get; set; }
    public ICollection<User> Users { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<Brand> Brands { get; set; }
    */

    #endregion
    #endregion
}