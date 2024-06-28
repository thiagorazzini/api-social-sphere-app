using Microsoft.EntityFrameworkCore;
using SocialSphereApp.API.Entities;

namespace SocialSphereApp.API.Persistence;

public class SocialSphereAppDbContext : DbContext
{
    public SocialSphereAppDbContext(
        DbContextOptions<SocialSphereAppDbContext> options)
        : base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Profile> Profiles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>(e =>
        {
            e.HasKey(u => u.Id);

            e.Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(100);

            e.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);

            e.Property(u => u.Mail)
                 .IsRequired()
                 .HasMaxLength(100);

            e.Property(u => u.DateOfBirth)
                 .IsRequired();

            e.Property(u => u.Phone)
                 .HasMaxLength(15);

            e.Property(u => u.Gender)
                 .IsRequired();

            e.Property(u => u.Pronun)
                 .HasMaxLength(50);


            e.HasOne(u => u.Profile)
                .WithOne(u => u.User)
                .HasForeignKey<Profile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

        });

        builder.Entity<Profile>(e =>
        {
            e.HasKey(p => p.Id);

            e.Property(p => p.Id) 
                .IsRequired();

            e.Property(p => p.DisplayName)
                .HasMaxLength(100);

            e.Property(p => p.About)
                .HasMaxLength(500);

            e.Property(p => p.Picture)
                 .HasColumnType("varbinary(max)");

            e.Property(p => p.Job)
                .HasMaxLength(100);

            e.Property(p => p.Gender)
                .IsRequired();//ok

            e.Property(p => p.Pronun)
                .HasMaxLength(50);//ok

            e.Property(p => p.CustomGender)
                .HasMaxLength(50);//ok

            e.Property(p => p.UserId)
             .IsRequired();

            e.HasOne(p => p.User)
                .WithOne(p => p.Profile)
                .HasForeignKey<User>(p => p.Id)
                .OnDelete(DeleteBehavior.Restrict);

            e.OwnsOne(p => p.Address, a =>
            {
                a.Property(d => d.Street).HasColumnName("Street");
                a.Property(d => d.Number).HasColumnName("Number");
                a.Property(d => d.ZipCode).HasColumnName("ZipCode");
                a.Property(d => d.District).HasColumnName("District");
                a.Property(d => d.City).HasColumnName("City");
                a.Property(d => d.State).HasColumnName("State");
                a.Property(d => d.Country).HasColumnName("Country");
            });

        });

        base.OnModelCreating(builder);
    }
}
