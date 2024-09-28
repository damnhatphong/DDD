using Microsoft.EntityFrameworkCore;
using TodoList.Domain.Entities;

namespace TodoList.Persistence.DBContext
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // use this method to directly config the database provider and the connection string.

            // another way is to use databasefactory to inject the connection configuration to the constructor, read more on this
            // Register Database Context - Different patterns supported at design time, https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // you can config the datatype, data length for each field of the dbset here
            // another way of doing it is to use data annotation, which I don't like because it pollute the domain entity
            // and the configurations are depended on the database type.
            base.OnModelCreating(modelBuilder);
            ConfigureTodoItemModel(modelBuilder);
        }

        public static void ConfigureTodoItemModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasKey(model => model.Id);
            /* -- OwnsMany vs HasMany --
            EF Core allows you to model entity types that can only ever appear on navigation properties of other entity types. 
            These are called owned entity types. The entity containing an owned entity type is its owner.

            Owned entities are essentially a part of the owner and cannot exist without it, they are conceptually similar to aggregates.
            This means that the owned entity is by definition on the dependent side of the relationship with the owner.
            */

            /* -- OwnsOne vs HasOne --
             * similar to OwnsMany and HasMany
             * read more on this https://learn.microsoft.com/en-us/ef/core/modeling/owned-entities
             */

            modelBuilder.Entity<TodoItem>().OwnsOne(model => model.Description);
            modelBuilder.Entity<TodoItem>().OwnsOne(model => model.Metadata);
        }
    }
}
