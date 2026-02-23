using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=CoreProjeDB.db");
    }
}
