using BackEnd.Entity;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Provider;

public class DataContext : DbContext{

    protected readonly IConfiguration Configuration;
    private string ConnectionString { get; init; }

    public DataContext(String connectionString) {
        ConnectionString = connectionString;
    }

    public DataContext(IConfiguration configuration) {
        Configuration = configuration;
        ConnectionString = Configuration.GetConnectionString("Default");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        modelBuilder.Entity<ActivityType>()
            .HasData(
                new ActivityType() { Id = 1, Name = "In" },
                new ActivityType() { Id = 2, Name = "Out" }
            );

    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<ActivityType> ActivityTypes { get; set; }
    public DbSet<EmployeeActivity> EmployeeActivities { get; set; }
    public DbSet<Quarentine> Quarentines { get; set; }

}
