using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class IslandContext : DbContext
{
    public IslandContext()
    {
    }

    public IslandContext(DbContextOptions<IslandContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserTable1> UserTable1s { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserTable1>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserTabl__1788CCAC5161DEA6");

            entity.ToTable("UserTable1");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Ability).IsUnicode(false);
            entity.Property(e => e.Area).IsUnicode(false);
            entity.Property(e => e.CellPhone)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ChangeTime).HasColumnType("datetime");
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.Modifier)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UseState)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UserSex)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
