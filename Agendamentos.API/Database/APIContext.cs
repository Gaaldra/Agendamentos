using Microsoft.EntityFrameworkCore;

namespace Agendamentos.API.Database;

public class APIContext : DbContext
{
    public APIContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
    {
        
    }
}
