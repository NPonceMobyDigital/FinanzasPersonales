using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Entities
{
    public partial class FinanzasPersonalesContext : DbContext
    {
        public FinanzasPersonalesContext()
        {
        }

        public FinanzasPersonalesContext(DbContextOptions<FinanzasPersonalesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Egreso> Egresos { get; set; } = null!;
        public virtual DbSet<EgresosFuturo> EgresosFuturos { get; set; } = null!;
        public virtual DbSet<Ingreso> Ingresos { get; set; } = null!;
        public virtual DbSet<IngresosFuturo> IngresosFuturos { get; set; } = null!;
        public virtual DbSet<Perfile> Perfiles { get; set; } = null!;
        public virtual DbSet<Saldo> Saldos { get; set; } = null!;
        public virtual DbSet<SaldosFuturo> SaldosFuturos { get; set; } = null!;
        public virtual DbSet<VistaPerfile> VistaPerfiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-E5HVRAU; Database=FinanzasPersonales; Trusted_Connection=True; TrustServerCertificate=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Egreso>(entity =>
            {
                entity.HasKey(e => e.IdEgreso);

                entity.Property(e => e.IdEgreso).HasColumnName("ID_Egreso");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaDeBaja).HasColumnType("datetime");
            });

            modelBuilder.Entity<EgresosFuturo>(entity =>
            {
                entity.HasKey(e => e.IdEgresosFuturos);

                entity.Property(e => e.IdEgresosFuturos).HasColumnName("Id_EgresosFuturos");

                entity.Property(e => e.Detalle).HasMaxLength(50);

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaEjecucion).HasColumnType("date");
            });

            modelBuilder.Entity<Ingreso>(entity =>
            {
                entity.HasKey(e => e.IdIngreso);

                entity.Property(e => e.IdIngreso).HasColumnName("ID_Ingreso");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            });

            modelBuilder.Entity<IngresosFuturo>(entity =>
            {
                entity.HasKey(e => e.IdIngresosFuturos)
                    .HasName("PK_INGRESOS_FUTUROS");

                entity.Property(e => e.IdIngresosFuturos).HasColumnName("ID_IngresosFuturos");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaEjecucion).HasColumnType("date");
            });

            modelBuilder.Entity<Perfile>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.Property(e => e.IdPerfil).HasColumnName("ID_Perfil");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.IdEgreso).HasColumnName("ID_Egreso");

                entity.Property(e => e.IdEgresoFuturo).HasColumnName("ID_EgresoFuturo");

                entity.Property(e => e.IdIngreso).HasColumnName("ID_Ingreso");

                entity.Property(e => e.IdIngresoFuturo).HasColumnName("ID_IngresoFuturo");

                entity.Property(e => e.IdSaldo).HasColumnName("ID_Saldo");

                entity.Property(e => e.IdSaldoFuturo).HasColumnName("ID_SaldoFuturo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEgresoNavigation)
                    .WithMany(p => p.Perfiles)
                    .HasForeignKey(d => d.IdEgreso)
                    .HasConstraintName("FK_Perfiles_Egresos");

                entity.HasOne(d => d.IdEgresoFuturoNavigation)
                    .WithMany(p => p.Perfiles)
                    .HasForeignKey(d => d.IdEgresoFuturo)
                    .HasConstraintName("FK_Perfiles_EgresosFuturos");

                entity.HasOne(d => d.IdIngresoNavigation)
                    .WithMany(p => p.Perfiles)
                    .HasForeignKey(d => d.IdIngreso)
                    .HasConstraintName("FK_Perfiles_Ingresos");

                entity.HasOne(d => d.IdIngresoFuturoNavigation)
                    .WithMany(p => p.Perfiles)
                    .HasForeignKey(d => d.IdIngresoFuturo)
                    .HasConstraintName("FK_Perfiles_IngresosFuturos");

                entity.HasOne(d => d.IdSaldoNavigation)
                    .WithMany(p => p.Perfiles)
                    .HasForeignKey(d => d.IdSaldo)
                    .HasConstraintName("FK_Perfiles_Saldos");

                entity.HasOne(d => d.IdSaldoFuturoNavigation)
                    .WithMany(p => p.Perfiles)
                    .HasForeignKey(d => d.IdSaldoFuturo)
                    .HasConstraintName("FK_Perfiles_SaldosFuturos");
            });

            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.HasKey(e => e.IdSaldo)
                    .HasName("PK_SALDOS");

                entity.Property(e => e.IdSaldo).HasColumnName("ID_Saldo");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaldosFuturo>(entity =>
            {
                entity.HasKey(e => e.IdMontoFuturo);

                entity.Property(e => e.IdMontoFuturo).HasColumnName("ID_MontoFuturo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaDeBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaDeConcrecion)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VistaPerfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaPerfiles");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoFuturo).HasColumnName("Saldo Futuro");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
