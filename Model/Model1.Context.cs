﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLCFEntities : DbContext
    {
        public QLCFEntities()
            : base("name=QLCFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ban> bans { get; set; }
        public virtual DbSet<calamviec> calamviecs { get; set; }
        public virtual DbSet<chamcong> chamcongs { get; set; }
        public virtual DbSet<cthoadon> cthoadons { get; set; }
        public virtual DbSet<douong> douongs { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<loaidouong> loaidouongs { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<View_HoaDonTong> View_HoaDonTong { get; set; }
    }
}
