using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace TargetPoker.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Model.Event> Events { get; set; }

        public DbSet<Model.Player> Players { get; set; }

        public DbSet<Model.EventPlayer> EventsPlayers { get; set; }

        public DataContext()
            : base("TargetPoker")
        {
            Database.SetInitializer<DataContext>(new CreateMySqlDatabaseIfNotExists<DbContext>());
            //Database.SetInitializer<DataContext>(null);            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.EventPlayer>()
                        .HasRequired(ep =>ep.Event)
                        .WithMany(e => e.Players).HasForeignKey(p => p.EventId);

            modelBuilder.Entity<Model.EventPlayer>()
                        .HasRequired(ep => ep.Player)
                        .WithMany(p => p.Events).HasForeignKey(p => p.PlayerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
