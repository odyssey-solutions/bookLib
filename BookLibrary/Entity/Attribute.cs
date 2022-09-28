using BookLibrary.Entity.Enum;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Entity;
public class Attribute : BaseEntity
{
    public Attribute() : base(EntityTypeEnum.Attribute)
    {
    }

    public string Label { get; set; } // cell number
    public string Description { get; set; } // cell number of....
    
    #region Relationships

    public int AttributeTypeId { get; set; }
    #region Relationship Objects
    
    public AttributeType AttributeType { get; set; } // structure of data 
    public ICollection<AttributeData> AttributeDatas { get; set; } // the data
    
    #endregion

    #endregion
}