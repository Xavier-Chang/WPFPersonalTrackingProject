using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class PERSONALTRACKINGContext : DbContext
    {
        public PERSONALTRACKINGContext()
        {
        }

        public PERSONALTRACKINGContext(DbContextOptions<PERSONALTRACKINGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Permissionstate> Permissionstate { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Salary> Salary { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Taskstate> Taskstate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.; Database=PERSONALTRACKING; trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPLOYEE_DEPARTMENT");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPLOYEE_POSITION");
            });

            modelBuilder.Entity<Months>(entity =>
            {
                entity.ToTable("MONTHS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("PERMISSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PermissionDay)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PermissionEndDate).HasColumnType("date");

                entity.Property(e => e.PermissionExplanation).IsUnicode(false);

                entity.Property(e => e.PermissionStartDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERMISSION_EMPLOYEE");

                entity.HasOne(d => d.PermissionStateNavigation)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.PermissionState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERMISSION_PERMISSIONSTATE");
            });

            modelBuilder.Entity<Permissionstate>(entity =>
            {
                entity.ToTable("PERMISSIONSTATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Statename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("POSITION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Position)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POSITION_DEPARTMENT");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.ToTable("SALARY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SalaryNavigation)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Salary_EMPLOYEE");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.Salary)
                    .HasForeignKey(d => d.MonthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Salary_MONTHS");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("TASK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TaskContent).IsUnicode(false);

                entity.Property(e => e.TaskDeliveryDate).HasColumnType("date");

                entity.Property(e => e.TaskStartDate).HasColumnType("date");

                entity.Property(e => e.TaskState).ValueGeneratedOnAdd();

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TASK_EMPLOYEE");

                entity.HasOne(d => d.TaskStateNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.TaskState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TASK_TASKSTATE");
            });

            modelBuilder.Entity<Taskstate>(entity =>
            {
                entity.ToTable("TASKSTATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
