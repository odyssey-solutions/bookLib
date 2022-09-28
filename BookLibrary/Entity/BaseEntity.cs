using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Entity.Enum;

namespace BookLibrary.Entity
{
    public class BaseEntity
    {
        public BaseEntity(EntityTypeEnum entityTypeEnum)
        {
            if (Id <= 0) return;
            //get attribute data for user
            using BookLibraryContext dbContext = new BookLibraryContext();

            AttributeDatas = dbContext.AttributeData
                .Where(at =>
                    at.ParentEntityTypeId == (int)entityTypeEnum
                    && at.ParentId == Id)
                .ToList();
        }
        public int Id { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
        public bool Archived { get; set; }

        // TODO: DH -   On save, trigger an internal function to write this collection out to DB
        //              On load (construction with an ID) read in all attributeData for this entity 
        [NotMapped]
        public ICollection<AttributeData> AttributeDatas { get; set; }
    }
}
