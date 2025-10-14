using Microsoft.EntityFrameworkCore;

namespace Agendamentos.API.Database;

public class APIContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = Environment.GetEnvironmentVariable("MYSQL_URI")!;
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}
