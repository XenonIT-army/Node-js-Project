namespace DAL.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<TaskInfo> City { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TaskInfo>()
                .Property(e => e.Text)
                .IsUnicode(false);

        }
    }
}
