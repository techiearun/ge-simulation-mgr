﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimulationManager.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gesimcontrolEntities : DbContext
    {
        public gesimcontrolEntities()
            : base("name=gesimcontrolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Experiment> Experiments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Run> Runs { get; set; }
        public DbSet<Simulation> Simulations { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}