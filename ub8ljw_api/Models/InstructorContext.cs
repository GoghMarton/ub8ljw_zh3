using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ub8ljw_api.Models;

public partial class InstructorContext : DbContext
{
    public InstructorContext()
    {
    }

    public InstructorContext(DbContextOptions<InstructorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Instructor> Instructor { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ub8ljw\\source\\repos\\zh3\\ub8ljw_zh3\\ub8ljw_zh3\\TanarDatabase.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InstructorSk).HasName("PK__Instruct__9D017A28C86DF4E3");

            entity.Property(e => e.InstructorSk)
                .ValueGeneratedNever()
                .HasColumnName("InstructorSK");
            entity.Property(e => e.EmployementId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmployementID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(10);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
