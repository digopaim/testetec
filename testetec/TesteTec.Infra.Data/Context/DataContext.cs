using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;
using TesteTec.Infra.Data.Mappings;

namespace TesteTec.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Rick> Ricks { get; set; }
        //public DbSet<Morty> Morties { get; set; }
        public DbSet<Dimensao> Dimensao { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Rick>().HasOne(p => p.Dimensao).WithOne();
            //modelBuilder.Entity<Morty>().HasOne(p => p.Rick).();
            //modelBuilder.Entity<Dimensao>();
            modelBuilder.ApplyConfiguration(new RickMap());
            modelBuilder.ApplyConfiguration(new MortyMap());
            modelBuilder.ApplyConfiguration(new DimensaoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
