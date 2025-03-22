using BlazorApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Components.Models.ModelsDataBases;

public class DataBaseContext : DbContext
{
    public DbSet<TestModel> Tests { get; set; }
    
    public DbSet<QuestionModel> Questions { get; set; }

    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TestModel>()
            .HasMany(o => o.QuestionModels)
            .WithOne(u => u.Test)
            .HasForeignKey(o => o.TestModelId);
    }


}