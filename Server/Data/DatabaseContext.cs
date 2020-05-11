namespace Server.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Dialog> Dialogs { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dialog>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dialog>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Dialogs)
                .Map(m => m.ToTable("DialogUser").MapLeftKey("DialogId").MapRightKey("UserId"));

            modelBuilder.Entity<File>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);
        }
    }
}
