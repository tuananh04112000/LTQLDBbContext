using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTQLDBbContext.Models
{
    public class LTQLDbContext1 : DbContext
    {
        public LTQLDbContext1() : base("name = LTQLDbContext1")
        {

        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<khachhang> khachhangs  { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .Property(e => e.Username)
            .IsUnicode(false);
            modelBuilder.Entity<khachhang>()
           .Property(e => e.MaKhachHang)
           .IsUnicode(false);
        }

    }
}