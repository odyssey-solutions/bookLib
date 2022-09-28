using BookLibrary.Entity.Enum;

namespace BookLibrary.Entity;

public class State : BaseEntity
{
    public State() : base(EntityTypeEnum.State)
    {
    }
    public string Value { get; set; }
    
    
        
    #region Relationships
    public int? ParentId { get; set; }
    
    #region Relationship Objects

    public State Parent { get; set; }
    public ICollection<State> States { get; set; }

    public ICollection<AttributeData> AttributeDatas { get; set; }
    public ICollection<AttributeType> AttributeTypes { get; set; }
    /*
    public ICollection<Scheme> Schemes { get; set; }
    public ICollection<Ticket> Tickets { get; set; }
    public ICollection<Membership> Memberships { get; set; }
    public ICollection<Brand> Brands { get; set; }
    public ICollection<AuthData> AuthDatas { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<Supplier> Suppliers { get; set; }
    public ICollection<Client> Clients { get; set; }
    public ICollection<Communication> Communications { get; set; }
    public ICollection<User> Users { get; set; }
    */

    #endregion
    #endregion
}