using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class NeighlinkDBContext : DbContext
    {
        public NeighlinkDBContext() : base("neighlinkDBConnection")
        {
            Database.SetInitializer<NeighlinkDBContext>(new DropCreateDatabaseIfModelChanges<NeighlinkDBContext>());
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Condominium> Condominiums { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                    //Por defecto todas nuestras entidades se crean con status true
                    ((BaseEntity)entity.Entity).Status = true;
                }

                if (entity.State == EntityState.Deleted)
                {
                    ((BaseEntity)entity.Entity).DeletedAt = now;
                }

                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }
    }
}
