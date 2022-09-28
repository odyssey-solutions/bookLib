using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookLibrary.Entity.Enum;

namespace BookLibrary.Entity;

public class AttributeData : BaseEntity
{

    public AttributeData() : base(EntityTypeEnum.AttributeData)
    {
    }
    public string Value { get; set; } //0815839079
    public DateTime? DateTimeEnd { get; set; } // only populated when state is not active
    
    #region Relationships

    public int AttributeId { get; set; }
    public int? StateId { get; set; }
        
    public int? ParentId { get; set; }
    public int? ParentEntityTypeId { get; set; }
    
    #region Relationship Objects
    
    public State State { get; set; }
    public Attribute Attribute { get; set; }
    public EntityType ParentEntityType { get; set; }

    #endregion

    #endregion
}