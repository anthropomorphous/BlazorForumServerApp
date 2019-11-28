﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorServerAppDB.Data.BlazorServerApp
{
    public partial class BlazorserverappContext : DbContext
    {
        public BlazorserverappContext()
        {
        }

        public BlazorserverappContext(DbContextOptions<BlazorserverappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MessageTable> MessageTable { get; set; }
        public virtual DbSet<ThemeTable> ThemeTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MessageTable>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<ThemeTable>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ThemeName).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}