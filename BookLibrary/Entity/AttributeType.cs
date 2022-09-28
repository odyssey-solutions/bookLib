using BookLibrary.Entity.Enum;

namespace BookLibrary.Entity;

public class AttributeType : BaseEntity
{
    public AttributeType() : base(EntityTypeEnum.AttributeType)
    {
    }
    public string Label { get; set; } // like email etc
    public string DataType { get; set; } // string
    public string DataFormat { get; set; } // string (json object?)
    public string EntityClass { get; set; } // like DomainLayer.Models.User
    public DateTime DateTimeEnd { get; set; }

    #region Relationships

    #region Relationship Objects
    
    public ICollection<Attribute> Attributes { get; set; }

    #endregion

    #endregion
}