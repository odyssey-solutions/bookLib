using BookLibrary.Entity;
using Microsoft.EntityFrameworkCore;
using Attribute = System.Attribute;

namespace BookLibrary.Data
{
    public class BookLibraryContext : DbContext
    {
        public BookLibraryContext()
        {

        }

        public BookLibraryContext(DbContextOptions<BookLibraryContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.Entity<Ticket>().HasOne(au => au.User).WithMany(e => e.UserTickets);
            modelBuilder.Entity<Ticket>().HasOne(au => au.Agent).WithMany(e => e.AgentTickets);
            modelBuilder.Entity<User>().HasOne(au => au.UserType).WithMany(e => e.UserTypes);
            modelBuilder.Entity<User>().HasOne(au => au.ParentType).WithMany(e => e.Users);
            
            modelBuilder
                .Entity<EntityType>().HasData(
                    Enum.GetValues(typeof(EntityTypeEnum))
                        .Cast<EntityTypeEnum>()
                        .Select(e => new EntityType()
                        {
                            Id = (int)e,
                            EntityClass = "DomainLayer.Models." + e.ToString(),
                            Label = e.ToString(),
                            DateTimeCreated = DateTime.Now,
                            DateTimeModified = DateTime.Now
                        })
                );
            
            modelBuilder
                .Entity<Tag>().HasData(
                    Enum.GetValues(typeof(TagsEnum))
                        .Cast<TagsEnum>()
                        .Select(e => new Tag()
                        {
                            Id = (int)e,
                            Value = e.ToString(),
                            DateTimeCreated = DateTime.Now,
                            DateTimeModified = DateTime.Now
                        })
                );
                */

        }

        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        
        public DbSet<BookReview> BookReviews { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeData> AttributeData { get; set; }
        public DbSet<AttributeType> AttributeType { get; set; }
        public DbSet<EntityType> EntityType { get; set; }
        public DbSet<State> State { get; set; }

    }
}
