namespace MVC_Print_PDF.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppEntities : DbContext
    {
        public AppEntities()
            : base("name=AppEntities")
        {
        }

        public virtual DbSet<EmployeeInfo> EmployeeInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.EmpName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.HRA)
                .HasPrecision(12, 1);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.TA)
                .HasPrecision(13, 2);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.DA)
                .HasPrecision(13, 2);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.GrossSalary)
                .HasPrecision(16, 2);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.TDS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.NetSalary)
                .HasPrecision(20, 4);
        }
    }
}
