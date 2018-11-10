using SalesApp.Interfaces;
using SalesApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Data
{
    class SalesContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesPerson> People { get; set;}
        public DbSet<SalesRegion> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            var stateMananger = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager;

            var deletedEntities = stateMananger
                .GetObjectStateEntries(EntityState.Deleted)
                .Select(e => e.Entity)
                .OfType<IActive>()
                .ToArray();

            foreach (var deletedEntity in deletedEntities)
            {
                if (deletedEntity == null) continue;
                stateMananger.ChangeObjectState(deletedEntity, EntityState.Modified);
                deletedEntity.Active = false;
            }

            var createdEntities = stateMananger
                .GetObjectStateEntries(EntityState.Added)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var createdEntity in createdEntities)
            {
                createdEntity.CreatedDate = DateTime.Now;
                createdEntity.CreatedBy = Environment.UserName;
                createdEntity.UpdatedDate = DateTime.Now;
                createdEntity.UpdatedBy = Environment.UserName;
            }


            var updatedEntities = stateMananger
                .GetObjectStateEntries(EntityState.Modified)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var updatedEntity in updatedEntities)
            {

                updatedEntity.UpdatedDate = DateTime.Now;
                updatedEntity.UpdatedBy = Environment.UserName;
            }

            return base.SaveChanges();
        }
    }
}
