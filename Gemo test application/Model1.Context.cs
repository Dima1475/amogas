﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gemo_test_application
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GemoTestEntities : DbContext
    {
        public GemoTestEntities()
            : base("name=GemoTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Analyzes> Analyzes { get; set; }
        public virtual DbSet<AnalyzesForOrder> AnalyzesForOrder { get; set; }
        public virtual DbSet<AnalyzesForStudy> AnalyzesForStudy { get; set; }
        public virtual DbSet<AnalyzesResults> AnalyzesResults { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Elements> Elements { get; set; }
        public virtual DbSet<ElementsNeedForAnalyze> ElementsNeedForAnalyze { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServicesForStudy> ServicesForStudy { get; set; }
        public virtual DbSet<Study> Study { get; set; }
    }
}
