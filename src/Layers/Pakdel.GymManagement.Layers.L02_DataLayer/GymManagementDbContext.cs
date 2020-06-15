using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pakdel.GymManagement.Layers.L01_Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Pakdel.GymManagement.Layers.L02_DataLayer
{
    public class GymManagementDbContext : DbContext
    {
        private IConfiguration _configuration;
        public GymManagementDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public GymManagementDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<FileStorage> FileStorages { get; set; }
        public virtual DbSet<Gym> Gyms { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<SportGym> SportGyms { get; set; }
        public virtual DbSet<UserGym> UserGyms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServer:ApplicationDbContextConnection"),
               serverDbContextOptionsBuilder =>
               {
                   var minutes = (int)TimeSpan.FromMinutes(3).TotalSeconds;
                   serverDbContextOptionsBuilder.CommandTimeout(minutes);
                   serverDbContextOptionsBuilder.EnableRetryOnFailure();
               });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username).IsUnique();
                entity.HasIndex(b => b.Username);
                entity.HasIndex(b => b.Id);
                entity.HasOne(d => d.GroupAuth).WithMany(t => t.Users).HasForeignKey(d => d.GroupAuthId);

            });


            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.Title).IsUnique();
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
                entity.HasOne(d => d.Role).WithMany(p => p.UserRoles).HasForeignKey(d => d.RoleId);
                entity.HasOne(d => d.User).WithMany(p => p.UserRoles).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasOne(ut => ut.User).WithMany(u => u.UserTokens).HasForeignKey(ut => ut.UserId);
                entity.HasIndex(ut => ut.UserId);
            });

        }
    }
}
