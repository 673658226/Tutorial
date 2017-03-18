namespace users.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=users")
        {
        }

        public virtual DbSet<user_info> user_info { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user_info>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<user_info>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Psw)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .HasOptional(e => e.user_info)
                .WithRequired(e => e.users);
        }
    }
}
