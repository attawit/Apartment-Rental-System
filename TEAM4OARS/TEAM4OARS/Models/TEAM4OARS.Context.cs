﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEAM4OARS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TEAM4OARSEntities : DbContext
    {
        public TEAM4OARSEntities()
            : base("name=TEAM4OARSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<Own> Owns { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Rental_Invoice> Rental_Invoice { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<Tenant_Auto> Tenant_Auto { get; set; }
        public virtual DbSet<Tenant_Family> Tenant_Family { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<View_LeaseLength> View_LeaseLength { get; set; }
        public virtual DbSet<View_Rental> View_Rental { get; set; }
        public virtual DbSet<View_Tenant> View_Tenant { get; set; }
        public virtual DbSet<View_VacantApt> View_VacantApt { get; set; }
    }
}