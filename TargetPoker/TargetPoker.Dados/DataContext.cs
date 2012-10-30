using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TargetPoker.Entidade;

namespace TargetPoker.Dados
{
    public class DataContext : DbContext
    {
        public DbSet<Entidade.Evento> Eventos { get; set; }

        public DbSet<Entidade.Jogador> Jogadores { get; set; }

        public DbSet<Entidade.EventoJogador> EventosJogadores { get; set; }

        public DataContext()
            : base("ConnectionStringDefault")
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidade.Evento>()
                        .HasMany(b => b.Jogadores)
                        .WithMany();

            modelBuilder.Entity<Entidade.Jogador>()
                        .HasMany(b => b.Eventos)
                        .WithMany();

            base.OnModelCreating(modelBuilder);
        }
    }
}
