using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AFFILIATES.GB.Models
{
    public partial class AffiliatesDbContext : DbContext
    {
        public AffiliatesDbContext()
        {
           
        }

        public AffiliatesDbContext(DbContextOptions<AffiliatesDbContext> options)
            : base(options)
        {
            
        }        
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }



        public virtual DbSet<AffiliateContractServices> AffiliateContractServices { get; set; }
        public virtual DbSet<AffiliateContracts> AffiliateContracts { get; set; }
        public virtual DbSet<Affiliates> Affiliates { get; set; }

        public virtual DbSet<ContractStatus> ContractStatus { get; set; }
        public virtual DbSet<Services> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=AFILIACION_GV;Trusted_Connection=True;MultipleActiveResultSets=true;User Id=uranus; Password=kronosRex2020.;").UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AffiliateContractServices>(entity =>
            {
                entity.HasIndex(e => new { e.AffiliateContractId, e.ServiceId })
                    .HasName("IX_AFFILIATE_CONTRACT_SERVICES_1")
                    .IsUnique();

                entity.HasOne(d => d.AffiliateContract)
                    .WithMany(p => p.AffiliateContractServices)
                    .HasForeignKey(d => d.AffiliateContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AFFILIATE_CONTRACT_SERVICES_AFFILIATE_CONTRACTS");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.AffiliateContractServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AFFILIATE_CONTRACT_SERVICES_SERVICES");
            });

            modelBuilder.Entity<AffiliateContracts>(entity =>
            {
                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateContracts)
                    .HasForeignKey(d => d.AffiliateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AFFILIATE_CONTRACTS_AFFILIATES");

                entity.HasOne(d => d.ContractStatu)
                    .WithMany(p => p.AffiliateContracts)
                    .HasForeignKey(d => d.ContractStatuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AFFILIATE_CONTRACTS_CONTRACT_STATUS");
            });

            modelBuilder.Entity<Affiliates>(entity =>
            {
                entity.HasIndex(e => e.NationalId)
                    .HasName("IX_AFFILIATES")
                    .IsUnique();
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_SERVICES")
                    .IsUnique();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
