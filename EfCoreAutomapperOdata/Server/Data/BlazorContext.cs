using EfCoreAutomapperOdata.Server.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace EfCoreAutomapperOdata.Server.Data
{
    public class BlazorContext : DbContext
    {
        public BlazorContext(DbContextOptions<BlazorContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<CourseStudent>().HasKey(x => new { x.CourseId, x.StudentId });
            modelBuilder.Entity<FriendsRel>().HasKey(x => new { x.FriendId, x.StudentId });

            modelBuilder.Entity<FriendsRel>()
                .HasOne(pt => pt.Student)
                .WithMany(p => p.Friends)
                .HasForeignKey(pt => pt.StudentId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Course> Course { get; set; }
        public DbSet<CourseStudent> CourseStudent { get; set; }
        public DbSet<FriendsRel> FriendsRel { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
