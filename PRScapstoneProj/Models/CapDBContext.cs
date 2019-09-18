using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRScapstoneProj.Models {
    public class CapDBContext : DbContext {

        public CapDBContext() {

        }

        public virtual DbSet<Users> User { get; set; }
        public virtual DbSet<Vendors> Vendor { get; set; }

        public virtual DbSet<Products> Product { get; set; }
        public virtual DbSet<Requests> Request { get; set; }

        public virtual DbSet<RequestLines> RequestLine { get; set; }

        public CapDBContext(DbContextOptions<CapDBContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(u => u.Username)
                .HasName("IDX_Username")
                .IsUnique();
            });

            {
                modelBuilder.Entity<Products>(entity =>
                {
                    entity.HasIndex(p => p.PartNbr)
                    .HasName("IDX_PartNbr")
                    .IsUnique();

                });

                modelBuilder.Entity<Vendors>(entity =>
                {
                    entity.HasIndex(v => v.Code)
                    .HasName("IDX_Code")
                    .IsUnique();

                });

               









        




            }
        }
    }
}

