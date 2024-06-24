﻿using Microsoft.EntityFrameworkCore;

namespace LinqExample.Console;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Asistant> Asistants { get; set; }

   override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=LinqExample;User Id=postgres;Password=mysecretpassword;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        modelBuilder.Entity<Course>()
            .HasOne(c => c.Asistant)
            .WithOne(a => a.Course)
            .HasForeignKey<Asistant>(a => a.Id);
        base.OnModelCreating(modelBuilder);
    }
}
